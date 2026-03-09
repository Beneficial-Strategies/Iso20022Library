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
    /// Choice of formats for applicable rules.
    /// </summary>
    [KnownType(typeof(ApplicableRules1Choice.Code))]
    [KnownType(typeof(ApplicableRules1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ApplicableRules1Choice.Code),nameof(ApplicableRules1Choice.Code))]
    [JsonDerivedType(typeof(ApplicableRules1Choice.Proprietary),nameof(ApplicableRules1Choice.Proprietary))]
    #endif
    [IsoId("_pSYd0FNeEeijdq8ilaxyOA")]
    [DisplayName("Applicable Rules 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ApplicableRules1Choice_
    #else
    public abstract partial class ApplicableRules1Choice_
    #endif
    {
    }
}
