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
/// Provides further details on the reason of the amendment of the creditor enrolment.
/// </summary>
[IsoId("_ULNL8eH7Eeqbls7Gk4-ckA")]
[DisplayName("Debtor Activation Amendment Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DebtorActivationAmendmentReason2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DebtorActivationAmendmentReason2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DebtorActivationAmendmentReason2( DebtorActivationAmendmentReason1Choice_ reqReason )
    {
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that issues the amendment request.
    /// </summary>
    [IsoId("_UMdwMeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RTPPartyIdentification1? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RTPPartyIdentification1? Originator { get; init; } 
    #else
    public RTPPartyIdentification1? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the amendment request.
    /// </summary>
    [IsoId("_UMdwM-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DebtorActivationAmendmentReason1Choice_ Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DebtorActivationAmendmentReason1Choice_ Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebtorActivationAmendmentReason1Choice_ Reason { get; init; } 
    #else
    public DebtorActivationAmendmentReason1Choice_ Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the amendment request reason.
    /// </summary>
    [IsoId("_UMdwNeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
