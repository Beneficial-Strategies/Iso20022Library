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
    /// Choice between details of missing information or the complete set of available information.
    /// </summary>
    [KnownType(typeof(UnableToApplyJustification1Choice.AnyInformation))]
    [KnownType(typeof(UnableToApplyJustification1Choice.MissingOrIncorrectInformation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnableToApplyJustification1Choice.AnyInformation),nameof(UnableToApplyJustification1Choice.AnyInformation))]
    [JsonDerivedType(typeof(UnableToApplyJustification1Choice.MissingOrIncorrectInformation),nameof(UnableToApplyJustification1Choice.MissingOrIncorrectInformation))]
    #endif
    [IsoId("_T-i3MNp-Ed-ak6NoX_4Aeg_-1347537926")]
    [DisplayName("Unable To Apply Justification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnableToApplyJustification1Choice_
    #else
    public abstract partial class UnableToApplyJustification1Choice_
    #endif
    {
    }
}
