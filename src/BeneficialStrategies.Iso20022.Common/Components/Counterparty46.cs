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
/// Information related to counterparty identification.
/// </summary>
[IsoId("_P6R6gQz4Ee2YoLD-1vFj0g")]
[DisplayName("Counterparty")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Counterparty46
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates if the counterparty is a legal entity or a natural person.
    /// </summary>
    [IsoId("_P7Cvgwz4Ee2YoLD-1vFj0g")]
    [DisplayName("Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdTp")]
    #endif
    [IsoXmlTag("IdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification248Choice_? IdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification248Choice_? IdentificationType { get; init; } 
    #else
    public PartyIdentification248Choice_? IdentificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the counterparty is a central counterparty, a financial, non-financial counterparty or other type of counterparty in accordance with regulation.
    /// </summary>
    [IsoId("_P7CvhQz4Ee2YoLD-1vFj0g")]
    [DisplayName("Nature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntr")]
    #endif
    [IsoXmlTag("Ntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CounterpartyTradeNature15Choice_? Nature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyTradeNature15Choice_? Nature { get; init; } 
    #else
    public CounterpartyTradeNature15Choice_? Nature { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of whether the counterparty 2 has the reporting obligation (irrespective of who is responsible and legally liable for its reporting).
    /// Usage: If the element is not present, the ReportingObligation is False.
    /// </summary>
    [IsoId("_P7Cvhwz4Ee2YoLD-1vFj0g")]
    [DisplayName("Reporting Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgOblgtn")]
    #endif
    [IsoXmlTag("RptgOblgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReportingObligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportingObligation { get; init; } 
    #else
    public System.String? ReportingObligation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
