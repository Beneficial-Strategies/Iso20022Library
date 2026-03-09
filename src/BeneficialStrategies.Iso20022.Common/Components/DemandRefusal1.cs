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
/// Information about the refusal of a demand.
/// </summary>
[IsoId("_-FHEkHltEeG7BsjMvd1mEw_-1919643766")]
[DisplayName("Demand Refusal")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DemandRefusal1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DemandRefusal1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DemandRefusal1( Undertaking9 reqUndertakingIdentification,Demand2 reqDemandDetails,System.String reqStatus )
    {
        UndertakingIdentification = reqUndertakingIdentification;
        DemandDetails = reqDemandDetails;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-FHEkXltEeG7BsjMvd1mEw_1257238828")]
    [DisplayName("Undertaking Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgId")]
    #endif
    [IsoXmlTag("UdrtkgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking9 UndertakingIdentification { get; init; } 
    #else
    public Undertaking9 UndertakingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the advising party to the undertaking.
    /// </summary>
    [IsoId("_-FHEknltEeG7BsjMvd1mEw_-400262050")]
    [DisplayName("Advising Party Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdvsgPtyRefNb")]
    #endif
    [IsoXmlTag("AdvsgPtyRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdvisingPartyReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdvisingPartyReferenceNumber { get; init; } 
    #else
    public System.String? AdvisingPartyReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the second advising party to the undertaking.
    /// </summary>
    [IsoId("_xcmwxRVREeKVqNjC36CBuQ")]
    [DisplayName("Second Advising Party Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndAdvsgPtyRefNb")]
    #endif
    [IsoXmlTag("ScndAdvsgPtyRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecondAdvisingPartyReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecondAdvisingPartyReferenceNumber { get; init; } 
    #else
    public System.String? SecondAdvisingPartyReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the confirmer to the undertaking.
    /// </summary>
    [IsoId("_-FHEk3ltEeG7BsjMvd1mEw_-671444297")]
    [DisplayName("Confirmer Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnfrmrRefNb")]
    #endif
    [IsoXmlTag("CnfrmrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ConfirmerReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConfirmerReferenceNumber { get; init; } 
    #else
    public System.String? ConfirmerReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the demand.
    /// </summary>
    [IsoId("_-FHElHltEeG7BsjMvd1mEw_866867684")]
    [DisplayName("Demand Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmndDtls")]
    #endif
    [IsoXmlTag("DmndDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Demand2 DemandDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Demand2 DemandDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Demand2 DemandDetails { get; init; } 
    #else
    public Demand2 DemandDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Expicit indication of &apos;REFUSED&apos; as the processing status reported by the issuer.
    /// </summary>
    [IsoId("_-FHElXltEeG7BsjMvd1mEw_1035244109")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    [IsoSimpleType(IsoSimpleType.Refused7Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRefused7Text Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Status { get; init; } 
    #else
    public System.String Status { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the discrepancies.
    /// </summary>
    [IsoId("_-FQ1kHltEeG7BsjMvd1mEw_733408168")]
    [DisplayName("Discrepancy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dscrpncy")]
    #endif
    [IsoXmlTag("Dscrpncy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Discrepancy1? Discrepancy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Discrepancy1? Discrepancy { get; init; } 
    #else
    public Discrepancy1? Discrepancy { get; set; } 
    #endif
    
    /// <summary>
    /// Indication of how the demand presentation documents will be handled as a consequence of the demand refusal.
    /// </summary>
    [IsoId("_-FQ1kXltEeG7BsjMvd1mEw_952637090")]
    [DisplayName("Disposition Of Documents")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DspstnOfDocs")]
    #endif
    [IsoXmlTag("DspstnOfDocs")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> DispositionOfDocuments { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Additional information related to the notification.
    /// </summary>
    [IsoId("_-FQ1knltEeG7BsjMvd1mEw_1467059748")]
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
