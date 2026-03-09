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
    /// Choice of providing the opening conditions or fixing conditions for an NDF instruction.
    /// </summary>
    [KnownType(typeof(NDFOpeningFixing1Choice.OpeningConditions))]
    [KnownType(typeof(NDFOpeningFixing1Choice.OpeningConfirmationReference))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NDFOpeningFixing1Choice.OpeningConditions),nameof(NDFOpeningFixing1Choice.OpeningConditions))]
    [JsonDerivedType(typeof(NDFOpeningFixing1Choice.OpeningConfirmationReference),nameof(NDFOpeningFixing1Choice.OpeningConfirmationReference))]
    #endif
    [IsoId("_1koBMJUIEeak6e8_Fc5fQg")]
    [DisplayName("NDF Opening Fixing 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NDFOpeningFixing1Choice_
    #else
    public abstract partial class NDFOpeningFixing1Choice_
    #endif
    {
    }
}
