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
    match model.Question with 
    | None -> str "Loading..."
    | Some question ->
        div []
            [ Media.media []
                [ Media.left [] 
                    [ Image.image [ Image.is16x16 ]
                        [ img [ Src "http://bulma.io/images/placeholders/128x128.png"]]]
                  Media.content []
                    [ str question.Title ]] ]
