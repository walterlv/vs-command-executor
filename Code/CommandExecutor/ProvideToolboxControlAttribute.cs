﻿using System;
using System.Globalization;
using Microsoft.VisualStudio.Shell;

namespace Walterlv.VisualStudio.CommandExecutor
{
    /// <summary>
    /// This attribute adds a ToolboxControlsInstaller key for the assembly to install toolbox controls from the assembly
    /// </summary>
    /// <remarks>
    /// For example
    ///     [$(Rootkey)\ToolboxControlsInstaller\$FullAssemblyName$]
    ///         "Codebase"="$path$"
    ///         "WpfControls"="1"
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed class ProvideToolboxControlAttribute : RegistrationAttribute
    {
        private const string ToolboxControlsInstallerPath = "ToolboxControlsInstaller";

        #region Constructors

        /// <summary>
        /// Creates a new ProvideToolboxControl attribute to register the assembly for toolbox controls installer
        /// </summary>
        /// <param name="isWpfControls"></param>
        public ProvideToolboxControlAttribute(string name, bool isWpfControls)
        {
            if (name == null)
            {
                throw new ArgumentException("name");
            }

            this.Name = name;
            this.IsWpfControls = isWpfControls;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets whether the toolbox controls are for WPF.
        /// </summary>
        private bool IsWpfControls { get; set; }

        /// <summary>
        /// Gets the name for the controls
        /// </summary>
        private string Name { get; set; }

        #endregion

        /// <summary>
        /// Called to register this attribute with the given context.  The context
        /// contains the location where the registration information should be placed.
        /// It also contains other information such as the type being registered and path information.
        /// </summary>
        /// <param name="context">Given context to register in</param>
        public override void Register(RegistrationAttribute.RegistrationContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            using (Key key = context.CreateKey(String.Format(CultureInfo.InvariantCulture, "{0}\\{1}",
                                                             ToolboxControlsInstallerPath,
                                                             context.ComponentType.Assembly.FullName)))
            {
                key.SetValue(String.Empty, this.Name);
                key.SetValue("Codebase", context.CodeBase);
                if (this.IsWpfControls)
                {
                    key.SetValue("WPFControls", "1");
                }
            }

        }

        public override void Unregister(RegistrationAttribute.RegistrationContext context)
        {
            if (context != null)
            {
                context.RemoveKey(String.Format(CultureInfo.InvariantCulture, "{0}\\{1}",
                                                             ToolboxControlsInstallerPath,
                                                             context.ComponentType.Assembly.FullName));
            }
        }
    }
}
