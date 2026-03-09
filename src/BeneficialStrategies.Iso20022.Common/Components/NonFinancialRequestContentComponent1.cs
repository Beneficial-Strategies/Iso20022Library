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
/// Aim of the non financial request.
/// </summary>
[IsoId("_4bs1QC_pEeugIJ3Gvoevmg")]
[DisplayName("Non Financial Request Content Component")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonFinancialRequestContentComponent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of non financial request that the Acceptor wants to be processed.
    /// </summary>
    [IsoId("_yZV_UC_rEeugIJ3Gvoevmg")]
    [DisplayName("Non Financial Request Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonFinReqTp")]
    #endif
    [IsoXmlTag("NonFinReqTp")]
    public SimpleValueList<NonFinancialRequestType1Code> NonFinancialRequestType { get; init; } = new SimpleValueList<NonFinancialRequestType1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _yZV_UC_rEeugIJ3Gvoevmg
    
    /// <summary>
    /// Card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_HDGRkC_sEeugIJ3Gvoevmg")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransaction107? Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction107? Transaction { get; init; } 
    #else
    public CardPaymentTransaction107? Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
