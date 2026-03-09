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
    /// Identifies which information are involved by a modification request for securities account reference data.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountModification1Choice.SystemSecuritiesAccount))]
    [KnownType(typeof(SecuritiesAccountModification1Choice.SystemRestriction))]
    [KnownType(typeof(SecuritiesAccountModification1Choice.MarketSpecificAttribute))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesAccountModification1Choice.SystemSecuritiesAccount),nameof(SecuritiesAccountModification1Choice.SystemSecuritiesAccount))]
    [JsonDerivedType(typeof(SecuritiesAccountModification1Choice.SystemRestriction),nameof(SecuritiesAccountModification1Choice.SystemRestriction))]
    [JsonDerivedType(typeof(SecuritiesAccountModification1Choice.MarketSpecificAttribute),nameof(SecuritiesAccountModification1Choice.MarketSpecificAttribute))]
    #endif
    [IsoId("_hjLnamliEeGaMcKyqKNRfQ_-966924713")]
    [DisplayName("Securities Account Modification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesAccountModification1Choice_
    #else
    public abstract partial class SecuritiesAccountModification1Choice_
    #endif
    {
    }
}
