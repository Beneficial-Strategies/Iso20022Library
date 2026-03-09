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
    /// Identifies a name of the identification scheme.
    /// </summary>
    [KnownType(typeof(ValidationRuleSchemeName1Choice.Code))]
    [KnownType(typeof(ValidationRuleSchemeName1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ValidationRuleSchemeName1Choice.Code),nameof(ValidationRuleSchemeName1Choice.Code))]
    [JsonDerivedType(typeof(ValidationRuleSchemeName1Choice.Proprietary),nameof(ValidationRuleSchemeName1Choice.Proprietary))]
    #endif
    [IsoId("_kAjWY9jGEeSD0e0ybx5L5Q")]
    [DisplayName("Validation Rule Scheme Name 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ValidationRuleSchemeName1Choice_
    #else
    public abstract partial class ValidationRuleSchemeName1Choice_
    #endif
    {
    }
}
