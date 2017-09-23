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
        [ article [ ClassName "media" ]
            [ figure [ClassName "media-left"]
                [ p [ ClassName "image is64x64"]
                    [ img [ Src "http://bulma.io/images/placeholders/128x128.png"]]]
              div [ ClassName "media-content" ]
                [ str "question text" ]] ]
