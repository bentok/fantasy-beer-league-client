module ReactHooks.UseState

open Fable.Core
open Fable.Core.JsInterop

type SetState<'t> = 't -> unit
let useState<'t> (t : 't) : 't * SetState<'t> = import "useState" "react"