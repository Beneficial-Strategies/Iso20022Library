// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance breakdown information.
/// </summary>
[IsoId("_m9_jwPNBEeCuA5Tr22BnwA_-274650344")]
[DisplayName("Portfolio Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PortfolioBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Summary balance information.
    /// </summary>
    [IsoId("_m9_jwfNBEeCuA5Tr22BnwA_1134139495")]
    [DisplayName("Summary Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SummryBal")]
    #endif
    [IsoXmlTag("SummryBal")]
    public ValueList<BalanceDetails5> SummaryBalance { get; init; } = new ValueList<BalanceDetails5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _m9_jwfNBEeCuA5Tr22BnwA_1134139495
    
    /// <summary>
    /// Detailed balance information.
    /// </summary>
    [IsoId("_m9_jwvNBEeCuA5Tr22BnwA_432347507")]
    [DisplayName("Detailed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldBal")]
    #endif
    [IsoXmlTag("DtldBal")]
    public ValueList<BalanceDetails6> DetailedBalance { get; init; } = new ValueList<BalanceDetails6>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _m9_jwvNBEeCuA5Tr22BnwA_432347507
    
    
    #nullable disable
    
}
