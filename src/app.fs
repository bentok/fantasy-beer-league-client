module App

open Fable.React
open Fable.Core.JsInterop
open ReactRouter.BrowserRouter
open ReactRouter.Link
open ReactRouter.Switch
open ReactRouter.Route
open Fulma

let App() =
    BrowserRouter [] [
        div [] [str "Hello from Fable-React Application!"]
        Link [To (!^ "/about")] [str "About"]
        Link [To (!^ "/")] [str "Home" ]
        Switch [] [
            Route [Path "/about"] [str "Content of the About page!"]
            Route [Path "/"] [str "Content of the Home page!"]
        ]
        
        // TODO: Make sure webpack loads css into index.html
        Tag.list
            [ Tag.List.HasAddons ]
            [ Tag.tag 
                [ Tag.Color IsDanger ]
                [ str "High priority" ]
              Tag.delete [ ] [ ]
            ]
    ]