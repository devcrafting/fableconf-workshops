module Question.Show.State

open Elmish
open Types
open Okular
open Okular.Operators
module Validation = Shared.Validation.Question

let init id  =
    Model.Empty, Cmd.none

let update msg model =
    match msg with
    | None ->
        model, Cmd.none
    | Increment ->
        { model with Model.Value = model.Value + 1 }, Cmd.none
    | Decrement ->
        { model with Model.Value = model.Value - 1 }, Cmd.none
