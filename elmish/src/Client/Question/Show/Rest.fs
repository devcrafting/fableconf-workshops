module Question.Show.Rest

open Fable.PowerPack
open Fable.PowerPack.Fetch
open Fable.Core.JsInterop
open Shared.Types

let getDetails id =
    promise {
        let url = serverUrl <| sprintf "/question/%i" id 
        let! res = fetchAs<Shared.Types.QuestionShow> url [ ]
        return res
    }