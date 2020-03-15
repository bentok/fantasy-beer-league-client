module App

open Fable.React
open Fable.Core.JsInterop
open ReactRouter.BrowserRouter
open ReactRouter.Link
open ReactRouter.Switch
open ReactRouter.Route
open Fulma

let home =
    Hero.hero [ Hero.Color IsSuccess
                Hero.IsMedium ]
        [ Hero.head [ ]
            [ Tabs.tabs [ Tabs.IsBoxed
                          Tabs.IsCentered ]
                [ Tabs.tab [ Tabs.Tab.IsActive true ]
                    [ Link [To (!^ "/")] [str "League" ] ]
                  Tabs.tab [ ]
                    [ Link [To (!^ "/team")] [str "Team"] ]
                  Tabs.tab [ ]
                    [ a [ ]
                        [ str "Match-ups" ] ]
                  Tabs.tab [ ]
                    [ a [ ]
                        [ str "Settings" ] ] ] ]
          Hero.body [ ]
            [ Container.container [ Container.IsFluid
                                    Container.Modifiers [ Modifier.TextAlignment (Screen.All, TextAlignment.Centered) ] ]
                [ Heading.h1 [ ]
                    [ str "Fantasy Beer League" ]
                  Heading.h2 [ Heading.IsSubtitle ]
                    [ str "Subtitle Here" ] ] ] ]

let App() =
    BrowserRouter [] [
        Switch [] [
            Route [Path "/team"] [str "Content of the Team page!"]
            Route [Path "/"] [(home)]
        ]
    ]