﻿
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace global

namespace NSPC
    // Generated by F# CodeDom
    #nowarn "49" // uppercase argument names
    #nowarn "67" // this type test or downcast will always hold
    #nowarn "66" // this upcast is unnecessary - the types are identical
    #nowarn "58" // possible incorrect indentation..
    #nowarn "57" // do not use create_DelegateEvent
    #nowarn "51" // address-of operator can occur in the code
    #nowarn "1183" // unused 'this' reference
    open System
    
    exception ReturnException87cb92fdf71d4650a299fd3c5d6056cc of obj
    exception ReturnNoneException87cb92fdf71d4650a299fd3c5d6056cc
    [<AutoOpen>]
    module FuncConvertFinalOverload87cb92fdf71d4650a299fd3c5d6056cc =
      // This extension member adds to the FuncConvert type and is the last resort member in the method overloading rules. 
      type global.Microsoft.FSharp.Core.FuncConvert with
          /// A utility function to convert function values from tupled to curried form
          static member FuncFromTupled (f:'T -> 'Res) = f
    
    type
        
        TestFields = class
            new() as this =
                {
                }
            static member UseConstantField  (i:int) =
                let mutable i = i
                ClassWithFields.ConstantField
            
            static member UseInternalField  (i:int) =
                let mutable i = i
                ClassWithFields.InternalField <- i
                ClassWithFields.InternalField
            
            static member UseNonStaticInternalField  (i:int) =
                let mutable i = i
                let mutable (variable:ClassWithFields) = new ClassWithFields()
                variable.NonStaticInternalField <- i
                variable.NonStaticInternalField
            
            static member UseNonStaticPublicField  (i:int) =
                let mutable i = i
                let mutable (variable:ClassWithFields) = new ClassWithFields()
                variable.NonStaticPublicField <- i
                variable.NonStaticPublicField
            
            static member UseStaticPublicField  (i:int) =
                let mutable i = i
                ClassWithFields.StaticPublicField <- i
                ClassWithFields.StaticPublicField
        end
    
    and
        
        TestProtectedField = class
            inherit ClassWithFields 
            new() as this =
                {
                }
            static member UseProtectedField  (i:int) =
                let mutable i = i
                ClassWithFields.ProtectedField <- i
                ClassWithFields.ProtectedField
        end
    
    and
        
        ClassWithFields = class
            [<Microsoft.FSharp.Core.DefaultValueAttribute(false)>]
            static val mutable private StaticPublicField:int
            
            [<Microsoft.FSharp.Core.DefaultValueAttribute(false)>]
            static val mutable private InternalField:int
            
            static member ConstantField = 0
            
            [<Microsoft.FSharp.Core.DefaultValueAttribute(false)>]
            static val mutable private ProtectedField:int
            
            [<Microsoft.FSharp.Core.DefaultValueAttribute(false)>]
            static val mutable private PrivateField:int
            
            [<Microsoft.FSharp.Core.DefaultValueAttribute(false)>]
            val mutable NonStaticPublicField:int
            
            [<Microsoft.FSharp.Core.DefaultValueAttribute(false)>]
            val mutable NonStaticInternalField:int
            new() as this =
                {
                } then
                        this.NonStaticInternalField <- 0;
                        this.NonStaticPublicField <- 5;
            static member UsePrivateField  (i:int) =
                let mutable i = i
                ClassWithFields.PrivateField <- i
                ClassWithFields.PrivateField
        end