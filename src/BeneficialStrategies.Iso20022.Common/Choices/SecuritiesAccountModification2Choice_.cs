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
    [KnownType(typeof(SecuritiesAccountModification2Choice.SystemSecuritiesAccount))]
    [KnownType(typeof(SecuritiesAccountModification2Choice.SystemRestriction))]
    [KnownType(typeof(SecuritiesAccountModification2Choice.MarketSpecificAttribute))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesAccountModification2Choice.SystemSecuritiesAccount),nameof(SecuritiesAccountModification2Choice.SystemSecuritiesAccount))]
    [JsonDerivedType(typeof(SecuritiesAccountModification2Choice.SystemRestriction),nameof(SecuritiesAccountModification2Choice.SystemRestriction))]
    [JsonDerivedType(typeof(SecuritiesAccountModification2Choice.MarketSpecificAttribute),nameof(SecuritiesAccountModification2Choice.MarketSpecificAttribute))]
    #endif
    [IsoId("_7-eWJTp0Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Modification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesAccountModification2Choice_
    #else
    public abstract partial class SecuritiesAccountModification2Choice_
    #endif
    {
    }
}
