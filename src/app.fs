module App

open Fable.React
open Fable.Core.JsInterop
open ReactRouter.BrowserRouter
open ReactRouter.Link
open ReactRouter.Switch
open ReactRouter.Route
open Fulma

open Home

let App() =
    BrowserRouter [] [
        Switch [] [
            Route [Path "/team"] [str "Content of the Team page!"]
            Route [Path "/"] [(home)]
        ]
    ]