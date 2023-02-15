module Main

open Feliz
open Elmish

type Msg =
    | OnChange of string

type Model =
    {
        Value : string
    }

let init () =
    {
        Value = ""
    }
    , Cmd.none

let update msg model =
    match msg with
    | OnChange newValue ->
        { model with
            Value = newValue
        }
        , Cmd.none

let view model dispatch =
    Html.div [
        Html.input [
            prop.onChange (fun newValue ->
                dispatch (  OnChange newValue)
            )
            prop.value model.Value
        ]
        Html.br []
        Html.div $"Value is: {model.Value}"
    ]

#if DEBUG
open Elmish.Debug
#endif
open Elmish.HMR

Program.mkProgram init update view
#if DEBUG
|> Program.withDebugger
#endif
|> Program.withReactBatched "root"
|> Program.run
