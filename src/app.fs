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


let headline() =
    let (greeting, setGreeting) =
        useState "Hello Functional Component"

    let onChange (event: Event) =
        let value: string = event.target?value
        setGreeting value

    let change = onChange

    div [] [
        h1 [] [str greeting]
        input [ OnChange change ]
    ]

let app() =
    BrowserRouter [] [
        Switch [] [
            Route [Path "/team"] [(headline())]
            Route [Path "/"] [(home())]
        ]
    ]