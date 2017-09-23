module Question.Show.State

open Elmish
open Types
open Okular
open Okular.Operators
module Validation = Shared.Validation.Question

let init id  =
    Model.Empty, Cmd.ofMsg <| FetchDetail id

let update msg model =
    match msg with
    | NetworkError error ->
        printfn "[Question.Show.State][Network error] %s" error.Message
        model, Cmd.none
    | FetchDetail id ->
        model, Cmd.ofPromise Rest.getDetails id FetchDetailSuccess NetworkError
    | FetchDetailSuccess result ->
        { model with Question = Some result.Question }, Cmd.none