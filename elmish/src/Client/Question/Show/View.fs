module Question.Show.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types
open Fulma.Layouts
open Fulma.Elements
open Fulma.Elements.Form
open Fulma.BulmaClasses
open Fulma.Components
open System

[<Pojo>]
type DangerousInnerHtml =
    { __html : string }

let htmlFromMarkdown str = div [ DangerouslySetInnerHTML { __html = Marked.Globals.marked.parse (str) } ] []

let root model dispatch =
    div []
        [ button [ OnClick (fun _ -> dispatch Increment)] [ str "Increment" ]
          button [ OnClick (fun _ -> dispatch Decrement)] [ str "Decrement" ]
          br []
          str <| string model.Value ]
