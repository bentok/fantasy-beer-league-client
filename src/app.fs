module App

open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop
open ReactHooks.UseState
open ReactRouter.BrowserRouter
open ReactRouter.Link
open ReactRouter.Switch
open ReactRouter.Route
open Browser.Types
open Fulma

open Home
open Login


let headline() =
    let (greeting, setGreeting) =
        useState "Hello Functional Component"

    let onChange (event: Event) =
        let value: string = event.target?value
        setGreeting value

    div [] [
        h1 [] [str greeting]
        input [ OnChange onChange ]
    ]

let app() =
    BrowserRouter [] [
        Switch [] [
            Route [Path "/team"] [(headline())]
            Route [Path "/login"] [(login())]
            Route [Path "/"] [(home())]
        ]
    ]