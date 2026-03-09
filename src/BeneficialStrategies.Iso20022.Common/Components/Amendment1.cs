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
/// Details of the amendment.
/// </summary>
[IsoId("_9-jwoHltEeG7BsjMvd1mEw_-951875342")]
[DisplayName("Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Amendment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Amendment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Amendment1( System.String reqSequenceNumber,System.DateOnly reqDateOfIssuance,Undertaking7 reqUndertakingIdentification )
    {
        SequenceNumber = reqSequenceNumber;
        DateOfIssuance = reqDateOfIssuance;
        UndertakingIdentification = reqUndertakingIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequence number assigned by the issuer to each proposed amendment of the undertaking.
    /// </summary>
    [IsoId("_9-jwoXltEeG7BsjMvd1mEw_-733763552")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax4AlphaNumericText SequenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SequenceNumber { get; init; } 
    #else
    public System.String SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the proposed amendment is issued.
    /// </summary>
    [IsoId("_9-jwonltEeG7BsjMvd1mEw_571423814")]
    [DisplayName("Date Of Issuance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfIssnc")]
    #endif
    [IsoXmlTag("DtOfIssnc")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate DateOfIssuance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly DateOfIssuance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly DateOfIssuance { get; init; } 
    #else
    public System.DateOnly DateOfIssuance { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the undertaking.
    /// </summary>
    [IsoId("_9-jwo3ltEeG7BsjMvd1mEw_1503262591")]
    [DisplayName("Undertaking Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgId")]
    #endif
    [IsoXmlTag("UdrtkgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking7 UndertakingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking7 UndertakingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking7 UndertakingIdentification { get; init; } 
    #else
    public Undertaking7 UndertakingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party asked to advise the proposed amendment to the beneficiary or to another advising party at the request of the issuer.
    /// </summary>
    [IsoId("_9-jwpHltEeG7BsjMvd1mEw_1390806841")]
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
    /// Additional party asked to advise the proposed amendment.
    /// </summary>
    [IsoId("_9-thoHltEeG7BsjMvd1mEw_922888858")]
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
    /// Details concerning the requested termination of the undertaking.
    /// </summary>
    [IsoId("_9-thoXltEeG7BsjMvd1mEw_279324661")]
    [DisplayName("Termination Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDtls")]
    #endif
    [IsoXmlTag("TermntnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UndertakingTermination3? TerminationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingTermination3? TerminationDetails { get; init; } 
    #else
    public UndertakingTermination3? TerminationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Requested increase or decrease to the amount of for the undertaking.
    /// </summary>
    [IsoId("_9-thonltEeG7BsjMvd1mEw_-1198886709")]
    [DisplayName("Undertaking Amount Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgAmtAdjstmnt")]
    #endif
    [IsoXmlTag("UdrtkgAmtAdjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UndertakingAmount2? UndertakingAmountAdjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingAmount2? UndertakingAmountAdjustment { get; init; } 
    #else
    public UndertakingAmount2? UndertakingAmountAdjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Requested new expiry terms for the undertaking.
    /// </summary>
    [IsoId("_9-tho3ltEeG7BsjMvd1mEw_-1424200957")]
    [DisplayName("New Expiry Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewXpryDtls")]
    #endif
    [IsoXmlTag("NewXpryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpiryDetails1? NewExpiryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpiryDetails1? NewExpiryDetails { get; init; } 
    #else
    public ExpiryDetails1? NewExpiryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Requested new beneficiary of the undertaking.
    /// </summary>
    [IsoId("_9-thpHltEeG7BsjMvd1mEw_1943469697")]
    [DisplayName("New Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewBnfcry")]
    #endif
    [IsoXmlTag("NewBnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? NewBeneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? NewBeneficiary { get; init; } 
    #else
    public PartyIdentification43? NewBeneficiary { get; set; } 
    #endif
    
    /// <summary>
    /// Requested new terms and conditions of the undertaking.
    /// </summary>
    [IsoId("_9-2rkHltEeG7BsjMvd1mEw_1346112541")]
    [DisplayName("New Undertaking Terms And Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewUdrtkgTermsAndConds")]
    #endif
    [IsoXmlTag("NewUdrtkgTermsAndConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Narrative1? NewUndertakingTermsAndConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Narrative1? NewUndertakingTermsAndConditions { get; init; } 
    #else
    public Narrative1? NewUndertakingTermsAndConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Amendment details related to the local undertaking.
    /// </summary>
    [IsoId("_iQNfYH8BEeGvEbxvurqpIg")]
    [DisplayName("Local Undertaking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclUdrtkg")]
    #endif
    [IsoXmlTag("LclUdrtkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Undertaking11? LocalUndertaking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking11? LocalUndertaking { get; init; } 
    #else
    public Undertaking11? LocalUndertaking { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not consent is requested from the beneficiary.
    /// </summary>
    [IsoId("_9-2rkXltEeG7BsjMvd1mEw_-270158341")]
    [DisplayName("Beneficiary Consent Request Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryCnsntReqInd")]
    #endif
    [IsoXmlTag("BnfcryCnsntReqInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BeneficiaryConsentRequestIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BeneficiaryConsentRequestIndicator { get; init; } 
    #else
    public System.String? BeneficiaryConsentRequestIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Communication channel for delivery of the proposed amendment.
    /// </summary>
    [IsoId("_9-2rknltEeG7BsjMvd1mEw_-1316238920")]
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
    /// Document or template enclosed in the proposed amendment.
    /// </summary>
    [IsoId("_9-2rk3ltEeG7BsjMvd1mEw_-1801397282")]
    [DisplayName("Enclosed File")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NclsdFile")]
    #endif
    [IsoXmlTag("NclsdFile")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Document9? EnclosedFile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Document9? EnclosedFile { get; init; } 
    #else
    public Document9? EnclosedFile { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the proposed amendment.
    /// </summary>
    [IsoId("_9-2rlHltEeG7BsjMvd1mEw_-1115047921")]
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
