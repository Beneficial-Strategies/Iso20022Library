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
/// Provides information regarding custodian service record.
/// </summary>
[IsoId("_1Q1ddDL3EeKU9IrkkToqcw_-1224843836")]
[DisplayName("Custodian Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustodianDetailsSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustodianDetailsSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustodianDetailsSD1( System.String reqPlaceAndName,System.String reqCustodianCorporateActionRecordIdentification,CustodianRecordAgreementType1Code reqAgreeIndicator,CustodianRecordCompletenessType1Code reqCompletenessIndicator,System.String reqReceivingBIC,System.String reqOriginatingBIC,System.String reqCompositeNotInSubscriptionFlag )
    {
        PlaceAndName = reqPlaceAndName;
        CustodianCorporateActionRecordIdentification = reqCustodianCorporateActionRecordIdentification;
        AgreeIndicator = reqAgreeIndicator;
        CompletenessIndicator = reqCompletenessIndicator;
        ReceivingBIC = reqReceivingBIC;
        OriginatingBIC = reqOriginatingBIC;
        CompositeNotInSubscriptionFlag = reqCompositeNotInSubscriptionFlag;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1Q1ddTL3EeKU9IrkkToqcw_-1664439967")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of a custodian corporate action record. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OcDL3EeKU9IrkkToqcw_1455084768")]
    [DisplayName("Custodian Corporate Action Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtdnCorpActnRcrdId")]
    #endif
    [IsoXmlTag("CtdnCorpActnRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CustodianCorporateActionRecordIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CustodianCorporateActionRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CustodianCorporateActionRecordIdentification { get; init; } 
    #else
    public System.String CustodianCorporateActionRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the state of the agreement of the custodian record when compared to composite record. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OcTL3EeKU9IrkkToqcw_751485142")]
    [DisplayName("Agree Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrInd")]
    #endif
    [IsoXmlTag("AgrInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CustodianRecordAgreementType1Code AgreeIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CustodianRecordAgreementType1Code AgreeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustodianRecordAgreementType1Code AgreeIndicator { get; init; } 
    #else
    public CustodianRecordAgreementType1Code AgreeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates state of the details of the custodian record on the system. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OcjL3EeKU9IrkkToqcw_2043159221")]
    [DisplayName("Completeness Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpltnsInd")]
    #endif
    [IsoXmlTag("CmpltnsInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CustodianRecordCompletenessType1Code CompletenessIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CustodianRecordCompletenessType1Code CompletenessIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustodianRecordCompletenessType1Code CompletenessIndicator { get; init; } 
    #else
    public CustodianRecordCompletenessType1Code CompletenessIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the status of custodian activity when applicable.
    /// </summary>
    [IsoId("_1Q_OczL3EeKU9IrkkToqcw_1424851471")]
    [DisplayName("Custodian Action Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtdnActnInd")]
    #endif
    [IsoXmlTag("CtdnActnInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustodianAction1Code? CustodianActionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustodianAction1Code? CustodianActionIndicator { get; init; } 
    #else
    public CustodianAction1Code? CustodianActionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates what action needs to be taken by the GCA (Global Corporate Action) validation service for this particular record. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OdDL3EeKU9IrkkToqcw_-356832207")]
    [DisplayName("GCA Action Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GCAActnInd")]
    #endif
    [IsoXmlTag("GCAActnInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GCAActionType1Code? GCAActionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GCAActionType1Code? GCAActionIndicator { get; init; } 
    #else
    public GCAActionType1Code? GCAActionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// BIC which is configured as a recipient of the custodian record. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OdTL3EeKU9IrkkToqcw_948233771")]
    [DisplayName("Receiving BIC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgBIC")]
    #endif
    [IsoXmlTag("RcvgBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier ReceivingBIC { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReceivingBIC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReceivingBIC { get; init; } 
    #else
    public System.String ReceivingBIC { get; set; } 
    #endif
    
    /// <summary>
    /// BIC which is configured as a sender of the custodian record. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1Q_OdjL3EeKU9IrkkToqcw_-1028930372")]
    [DisplayName("Originating BIC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgtgBIC")]
    #endif
    [IsoXmlTag("OrgtgBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier OriginatingBIC { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginatingBIC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginatingBIC { get; init; } 
    #else
    public System.String OriginatingBIC { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the event security of the corresponding composite record is on SOI (security of interest) subscription. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1RIYYDL3EeKU9IrkkToqcw_914356142")]
    [DisplayName("Composite Not In Subscription Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpsitNotInSbcptFlg")]
    #endif
    [IsoXmlTag("CmpsitNotInSbcptFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CompositeNotInSubscriptionFlag { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CompositeNotInSubscriptionFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CompositeNotInSubscriptionFlag { get; init; } 
    #else
    public System.String CompositeNotInSubscriptionFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Provides selected corporate action events message details extracted from the related custodian messages received. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1RIYYTL3EeKU9IrkkToqcw_1582463489")]
    [DisplayName("Related Custodian Message Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdCtdnMsgDtls")]
    #endif
    [IsoXmlTag("RltdCtdnMsgDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RelatedCustodianMessageDetailsSD1? RelatedCustodianMessageDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RelatedCustodianMessageDetailsSD1? RelatedCustodianMessageDetails { get; init; } 
    #else
    public RelatedCustodianMessageDetailsSD1? RelatedCustodianMessageDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
