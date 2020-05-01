module Login

open Fable.React
open Fable.React.Props
open ReactHooks.UseState
open Fable.Core.JsInterop
open ReactRouter.Link
open ReactRouter.Switch
open ReactRouter.Route
open Browser.Types
open Fulma

let login() =
    let (email, setEmail) =
        useState ""

    let onChange (event: Event) =
        let value: string = event.target?value
        setEmail value
        printfn "%s" email

    Container.container [ Container.IsFluid ] [
        Content.content [ ] [
            Card.card [ ] [
                Card.header [ ] [
                    Card.Header.title [ Card.Header.Title.IsCentered ]
                        [ str "Login" ] ]
                Card.content [ ] [
                    form [ ]
                         [
                            Field.div [ ] [
                                Label.label [ ] [ str "Email" ]
                                Control.div [ ] [
                                    Input.text [ Input.OnChange onChange ] ] ]
                            Field.div [ ] [
                                Label.label [ ] [ str "Password" ]
                                Control.div [ ] [
                                    Input.text [ ] ] ]
                            Field.div [ Field.IsGrouped ]
                                [ Control.div [ ]
                                    [ Button.button [ Button.Color IsPrimary ]
                                        [ str "Submit" ] ]
                                  Control.div [ ]
                                    [ Button.button [ Button.IsLink ]
                                        [ str "Cancel" ] ] ] ] ]
            ] 
        ]
    ]