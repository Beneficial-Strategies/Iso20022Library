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
/// Further information on the return reason of the transaction.
/// </summary>
[IsoId("_TPKBpdp-Ed-ak6NoX_4Aeg_2976420")]
[DisplayName("Return Reason Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReturnReasonInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party issuing the return.
    /// </summary>
    [IsoId("_TPKBptp-Ed-ak6NoX_4Aeg_1003149399")]
    [DisplayName("Return Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrOrgtr")]
    #endif
    [IsoXmlTag("RtrOrgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? ReturnOriginator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? ReturnOriginator { get; init; } 
    #else
    public PartyIdentification8? ReturnOriginator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_TPKBp9p-Ed-ak6NoX_4Aeg_515527494")]
    [DisplayName("Return Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrRsn")]
    #endif
    [IsoXmlTag("RtrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReturnReason1Choice_? ReturnReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReturnReason1Choice_? ReturnReason { get; init; } 
    #else
    public ReturnReason1Choice_? ReturnReason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_TPKBqNp-Ed-ak6NoX_4Aeg_84246003")]
    [DisplayName("Additional Return Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRtrRsnInf")]
    #endif
    [IsoXmlTag("AddtlRtrRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalReturnReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalReturnReasonInformation { get; init; } 
    #else
    public System.String? AdditionalReturnReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
