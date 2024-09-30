namespace TstFs.Views

open Avalonia
open Avalonia.Controls
open Avalonia.Markup.Xaml

type MainWindow () as this = 
    inherit UserControl ()

    do this.InitializeComponent ()

    member this.InitializeComponent () =
        AvaloniaXamlLoader.Load(this)
