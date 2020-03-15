module Main

open Fable.React
open Fable.Core.JsInterop
open App

importAll "./main.scss"

let document = Browser.Dom.window.document
let root = document.getElementById "root"

ReactDom.render(App(), root)