Visual Studio Command Executor
=====

| [English](https://github.com/walterlv/vs-command-executor/wiki/Home) | [简体中文](https://github.com/walterlv/vs-command-executor/wiki/Home.zh-CN) | [繁體中文](https://github.com/walterlv/vs-command-executor/wiki/Home.zh-TW) | [日本語](https://github.com/walterlv/vs-command-executor/wiki/Home.ja-JP)
|-----|-----|-----|-----|

This is a very convenient add-on to execute command under your solution directories. You can use it for your git source control, your project dependency swiching, or any other ideas in your mind.

------

## Clone & Start

This is a Visual Studio Extensibility. Before you start, you should download:
> * [.NET Framework 4.5.1]
> * [Visual Studio Community 2013 with Update 4]
> * [Visual Studio SDK].

[.NET Framework 4.5.1]:http://go.microsoft.com/?linkid=9831986
[Visual Studio Community 2013 with Update 4]:http://go.microsoft.com/?linkid=9863608
[Visual Studio SDK]:http://go.microsoft.com/?linkid=9832352

After you run the Visual Studio, follow these steps:
> 1. Right click the `CommandExecutor` project, select `properties`;
> 1. In the `CommandExecutor` tab, select `DEBUG` tab;
> 1. In the `Start Action` section, select `Start external program`;
> 1. Paste `C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe` in your textbox beside the `Start external program` label;
> 1. Paste `/rootsuffix Exp` in your textbox beside the `Command line arguments` label.

-----

## Contributors

> * [walterlv]

[walterlv]:https://github.com/walterlv
