// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details of missing information or the complete set of available information.
    /// </summary>
    [KnownType(typeof(UnableToApplyJustification2Choice.AnyInformation))]
    [KnownType(typeof(UnableToApplyJustification2Choice.MissingOrIncorrectInformation))]
    [KnownType(typeof(UnableToApplyJustification2Choice.PossibleDuplicateInstruction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnableToApplyJustification2Choice.AnyInformation),nameof(UnableToApplyJustification2Choice.AnyInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification2Choice.MissingOrIncorrectInformation),nameof(UnableToApplyJustification2Choice.MissingOrIncorrectInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification2Choice.PossibleDuplicateInstruction),nameof(UnableToApplyJustification2Choice.PossibleDuplicateInstruction))]
    #endif
    [IsoId("_T-i3M9p-Ed-ak6NoX_4Aeg_-1089125452")]
    [DisplayName("Unable To Apply Justification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnableToApplyJustification2Choice_
    #else
    public abstract partial class UnableToApplyJustification2Choice_
    #endif
    {
    }
}
