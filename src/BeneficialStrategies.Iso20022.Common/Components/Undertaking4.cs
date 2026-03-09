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
/// Information about an undertaking.
/// </summary>
[IsoId("_9zFgdXltEeG7BsjMvd1mEw_1035435998")]
[DisplayName("Undertaking")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Undertaking4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Undertaking4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Undertaking4( UndertakingName1Code reqName,ExternalUndertakingType1Code reqType,UndertakingAmount1 reqLocalUndertakingAmount,ExpiryDetails1 reqExpiryDetails,GovernanceRules1 reqGovernanceRulesAndLaw,UndertakingWording1 reqUndertakingWording )
    {
        Name = reqName;
        Type = reqType;
        LocalUndertakingAmount = reqLocalUndertakingAmount;
        ExpiryDetails = reqExpiryDetails;
        GovernanceRulesAndLaw = reqGovernanceRulesAndLaw;
        UndertakingWording = reqUndertakingWording;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the requested local undertaking such as, demand guarantee, standby letter of credit, surety.
    /// </summary>
    [IsoId("_9zFgdnltEeG7BsjMvd1mEw_-864566025")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingName1Code Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingName1Code Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingName1Code Name { get; init; } 
    #else
    public UndertakingName1Code Name { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the requested local undertaking such as performance, payment.
    /// </summary>
    [IsoId("_9zOqYHltEeG7BsjMvd1mEw_-1636131870")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalUndertakingType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalUndertakingType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalUndertakingType1Code Type { get; init; } 
    #else
    public ExternalUndertakingType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Party requested to be named in the local undertaking as the party on whose behalf the undertaking is issued.
    /// </summary>
    [IsoId("_9zOqYXltEeG7BsjMvd1mEw_-1559280949")]
    [DisplayName("Applicant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Applcnt")]
    #endif
    [IsoXmlTag("Applcnt")]
    public ValueList<PartyIdentification43> Applicant { get; init; } = new ValueList<PartyIdentification43>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _9zOqYXltEeG7BsjMvd1mEw_-1559280949
    
    /// <summary>
    /// Party in whose favour the requested local undertaking is to be issued.
    /// </summary>
    [IsoId("_9zOqYnltEeG7BsjMvd1mEw_1081181075")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    public ValueList<PartyIdentification43> Beneficiary { get; init; } = new ValueList<PartyIdentification43>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _9zOqYnltEeG7BsjMvd1mEw_1081181075
    
    /// <summary>
    /// Date on which the requested local undertaking is to be issued.
    /// </summary>
    [IsoId("_9zOqY3ltEeG7BsjMvd1mEw_-930204574")]
    [DisplayName("Date Of Issuance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfIssnc")]
    #endif
    [IsoXmlTag("DtOfIssnc")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateOfIssuance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateOfIssuance { get; init; } 
    #else
    public System.DateOnly? DateOfIssuance { get; set; } 
    #endif
    
    /// <summary>
    /// Party asked to advise the requested local undertaking to the beneficiary or to another advising party at the request of the local undertaking issuer.
    /// </summary>
    [IsoId("_WeZCcxSDEeKyNbjzgBLUcA")]
    [DisplayName("Advising Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdvsgPty")]
    #endif
    [IsoXmlTag("AdvsgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? AdvisingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? AdvisingParty { get; init; } 
    #else
    public PartyIdentification43? AdvisingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Additional party asked to advise the requested local undertaking.
    /// </summary>
    [IsoId("_rP0C8xSDEeKyNbjzgBLUcA")]
    [DisplayName("Second Advising Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndAdvsgPty")]
    #endif
    [IsoXmlTag("ScndAdvsgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? SecondAdvisingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? SecondAdvisingParty { get; init; } 
    #else
    public PartyIdentification43? SecondAdvisingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the amount of the local undertaking.
    /// </summary>
    [IsoId("_9zOqZHltEeG7BsjMvd1mEw_-1709390526")]
    [DisplayName("Local Undertaking Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclUdrtkgAmt")]
    #endif
    [IsoXmlTag("LclUdrtkgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingAmount1 LocalUndertakingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingAmount1 LocalUndertakingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingAmount1 LocalUndertakingAmount { get; init; } 
    #else
    public UndertakingAmount1 LocalUndertakingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the expiry of the requested local undertaking.
    /// </summary>
    [IsoId("_9zYbYXltEeG7BsjMvd1mEw_1290133370")]
    [DisplayName("Expiry Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDtls")]
    #endif
    [IsoXmlTag("XpryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExpiryDetails1 ExpiryDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExpiryDetails1 ExpiryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpiryDetails1 ExpiryDetails { get; init; } 
    #else
    public ExpiryDetails1 ExpiryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the advising bank (confirmer) is requested to add its confirmation to the undertaking.
    /// </summary>
    [IsoId("_56z_IxSAEeKyNbjzgBLUcA")]
    [DisplayName("Confirmation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfInd")]
    #endif
    [IsoXmlTag("ConfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ConfirmationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConfirmationIndicator { get; init; } 
    #else
    public System.String? ConfirmationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Party, in addition to the other parties specified in the requested local undertaking, that is also related to the requested local undertaking.
    /// </summary>
    [IsoId("_9zYbYnltEeG7BsjMvd1mEw_-1413623178")]
    [DisplayName("Additional Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPty")]
    #endif
    [IsoXmlTag("AddtlPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndType1? AdditionalParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndType1? AdditionalParty { get; init; } 
    #else
    public PartyAndType1? AdditionalParty { get; set; } 
    #endif
    
    /// <summary>
    /// Rules and laws governing the requested local undertaking.
    /// </summary>
    [IsoId("_9zYbY3ltEeG7BsjMvd1mEw_1952872268")]
    [DisplayName("Governance Rules And Law")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GovncRulesAndLaw")]
    #endif
    [IsoXmlTag("GovncRulesAndLaw")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GovernanceRules1 GovernanceRulesAndLaw { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GovernanceRules1 GovernanceRulesAndLaw { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GovernanceRules1 GovernanceRulesAndLaw { get; init; } 
    #else
    public GovernanceRules1 GovernanceRulesAndLaw { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the underlying transaction for which the undertaking is issued.
    /// </summary>
    [IsoId("_NC1go31qEeGlwNeVP9egyg")]
    [DisplayName("Underlying Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygTx")]
    #endif
    [IsoXmlTag("UndrlygTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingTradeTransaction1? UnderlyingTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingTradeTransaction1? UnderlyingTransaction { get; init; } 
    #else
    public UnderlyingTradeTransaction1? UnderlyingTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Presentation details related to the undertaking.
    /// </summary>
    [IsoId("_aUeqkxSAEeKyNbjzgBLUcA")]
    [DisplayName("Presentation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntnDtls")]
    #endif
    [IsoXmlTag("PresntnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Presentation1? PresentationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Presentation1? PresentationDetails { get; init; } 
    #else
    public Presentation1? PresentationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Wording details and text for the requested local undertaking.
    /// </summary>
    [IsoId("_AOEX1RR_EeKyNbjzgBLUcA")]
    [DisplayName("Undertaking Wording")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgWrdg")]
    #endif
    [IsoXmlTag("UdrtkgWrdg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingWording1 UndertakingWording { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingWording1 UndertakingWording { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingWording1 UndertakingWording { get; init; } 
    #else
    public UndertakingWording1 UndertakingWording { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that multiple demands are not permitted.
    /// </summary>
    [IsoId("_SbTu4xSAEeKyNbjzgBLUcA")]
    [DisplayName("Multiple Demand Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MltplDmndInd")]
    #endif
    [IsoXmlTag("MltplDmndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MultipleDemandIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MultipleDemandIndicator { get; init; } 
    #else
    public System.String? MultipleDemandIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that partial demands/drawings are not permitted.
    /// </summary>
    [IsoId("_En7ekxSAEeKyNbjzgBLUcA")]
    [DisplayName("Partial Demand Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlDmndInd")]
    #endif
    [IsoXmlTag("PrtlDmndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PartialDemandIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartialDemandIndicator { get; init; } 
    #else
    public System.String? PartialDemandIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the confirmation charges.
    /// </summary>
    [IsoId("_9zOqZXltEeG7BsjMvd1mEw_998876300")]
    [DisplayName("Confirmation Charges Payable By")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfChrgsPyblBy")]
    #endif
    [IsoXmlTag("ConfChrgsPyblBy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalTypeOfParty1Code? ConfirmationChargesPayableBy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTypeOfParty1Code? ConfirmationChargesPayableBy { get; init; } 
    #else
    public ExternalTypeOfParty1Code? ConfirmationChargesPayableBy { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the applicant/obligor or beneficiary is responsible for payment of the transfer charges.
    /// </summary>
    [IsoId("_9zYbYHltEeG7BsjMvd1mEw_1020340301")]
    [DisplayName("Transfer Charges Payable By")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfChrgsPyblBy")]
    #endif
    [IsoXmlTag("TrfChrgsPyblBy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalTypeOfParty1Code? TransferChargesPayableBy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalTypeOfParty1Code? TransferChargesPayableBy { get; init; } 
    #else
    public ExternalTypeOfParty1Code? TransferChargesPayableBy { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to a variation in amount that is automatically applied.
    /// </summary>
    [IsoId("_WEveQxSBEeKyNbjzgBLUcA")]
    [DisplayName("Automatic Amount Variation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AutomtcAmtVartn")]
    #endif
    [IsoXmlTag("AutomtcAmtVartn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AutomaticVariation1? AutomaticAmountVariation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutomaticVariation1? AutomaticAmountVariation { get; init; } 
    #else
    public AutomaticVariation1? AutomaticAmountVariation { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the communication channel.
    /// </summary>
    [IsoId("_TSG81X8LEeGvEbxvurqpIg")]
    [DisplayName("Delivery Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryChanl")]
    #endif
    [IsoXmlTag("DlvryChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationChannel1? DeliveryChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationChannel1? DeliveryChannel { get; init; } 
    #else
    public CommunicationChannel1? DeliveryChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the requested local undertaking is transferable.
    /// </summary>
    [IsoId("_4WwA0xR_EeKyNbjzgBLUcA")]
    [DisplayName("Transfer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfInd")]
    #endif
    [IsoXmlTag("TrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TransferIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferIndicator { get; init; } 
    #else
    public System.String? TransferIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the requested local undertaking.
    /// </summary>
    [IsoId("_9ziMYHltEeG7BsjMvd1mEw_228131973")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
