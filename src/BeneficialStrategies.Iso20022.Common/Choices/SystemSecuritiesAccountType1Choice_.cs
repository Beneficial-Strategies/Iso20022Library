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
    /// Specifies the system securities account type.
    /// </summary>
    [KnownType(typeof(SystemSecuritiesAccountType1Choice.Code))]
    [KnownType(typeof(SystemSecuritiesAccountType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SystemSecuritiesAccountType1Choice.Code),nameof(SystemSecuritiesAccountType1Choice.Code))]
    [JsonDerivedType(typeof(SystemSecuritiesAccountType1Choice.Proprietary),nameof(SystemSecuritiesAccountType1Choice.Proprietary))]
    #endif
    [IsoId("_bLDjYDp0Eemk2e6qGBk8IQ")]
    [DisplayName("System Securities Account Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemSecuritiesAccountType1Choice_
    #else
    public abstract partial class SystemSecuritiesAccountType1Choice_
    #endif
    {
    }
}
