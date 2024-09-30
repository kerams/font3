namespace TstFs

open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Markup.Xaml
open TstFs.Views
open Avalonia.Controls

type App() =
    inherit Application()

    override this.Initialize() =
            AvaloniaXamlLoader.Load(this)

    override this.OnFrameworkInitializationCompleted() =
        match this.ApplicationLifetime with
        | :? ISingleViewApplicationLifetime as singleViewLifetime -> singleViewLifetime.MainView <- MainWindow ()
        | :? IClassicDesktopStyleApplicationLifetime as lt -> lt.MainWindow <- Window (Content = MainWindow ())
        | _ -> ()

        base.OnFrameworkInitializationCompleted()
