module Question.Show.Types

open Okular.Lens

type Model =
    { 
        Question : Shared.Types.Question option
        Value : int
    }

    static member Empty =
        { Question =  None; Value = 0 }

type Msg =
    | None
    | Increment
    | Decrement