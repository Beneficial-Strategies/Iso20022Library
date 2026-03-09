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
/// Details of the demand.
/// </summary>
[IsoId("_-AylQnltEeG7BsjMvd1mEw_1908468693")]
[DisplayName("Demand")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Demand1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Demand1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Demand1( System.String reqIdentification,DemandType1Code reqType,Undertaking6 reqUndertakingIdentification,UndertakingAmount3 reqDemandAmount )
    {
        Identification = reqIdentification;
        Type = reqType;
        UndertakingIdentification = reqUndertakingIdentification;
        DemandAmount = reqDemandAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the presenting party to the demand.
    /// </summary>
    [IsoId("_-AylQ3ltEeG7BsjMvd1mEw_-2057301709")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of demand.
    /// </summary>
    [IsoId("_-AylRHltEeG7BsjMvd1mEw_-1446215965")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DemandType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DemandType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DemandType1Code Type { get; init; } 
    #else
    public DemandType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the undertaking.
    /// </summary>
    [IsoId("_-AylRXltEeG7BsjMvd1mEw_-1068410070")]
    [DisplayName("Undertaking Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgId")]
    #endif
    [IsoXmlTag("UdrtkgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking6 UndertakingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking6 UndertakingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking6 UndertakingIdentification { get; init; } 
    #else
    public Undertaking6 UndertakingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the demand amount.
    /// </summary>
    [IsoId("_-AylRnltEeG7BsjMvd1mEw_-2023766673")]
    [DisplayName("Demand Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmndAmt")]
    #endif
    [IsoXmlTag("DmndAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingAmount3 DemandAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingAmount3 DemandAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingAmount3 DemandAmount { get; init; } 
    #else
    public UndertakingAmount3 DemandAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the advising party to the undertaking.
    /// </summary>
    [IsoId("_-A8WQHltEeG7BsjMvd1mEw_1331805812")]
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
    [IsoId("_8977YBVQEeKVqNjC36CBuQ")]
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
    [IsoId("_-A8WQXltEeG7BsjMvd1mEw_-346168184")]
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
    /// Details related to the settlement account.
    /// </summary>
    [IsoId("_-A8WQ3ltEeG7BsjMvd1mEw_-1782957178")]
    [DisplayName("Settlement Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAcct")]
    #endif
    [IsoXmlTag("SttlmAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount27? SettlementAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount27? SettlementAccount { get; init; } 
    #else
    public CashAccount27? SettlementAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the beneficiary&apos;s presentation of documents.
    /// </summary>
    [IsoId("_-A8WRHltEeG7BsjMvd1mEw_-275427375")]
    [DisplayName("Presentation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntnDtls")]
    #endif
    [IsoXmlTag("PresntnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Presentation2? PresentationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Presentation2? PresentationDetails { get; init; } 
    #else
    public Presentation2? PresentationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Requested new expiry date as an alternative to payment of the demand.
    /// </summary>
    [IsoId("_-BGHQHltEeG7BsjMvd1mEw_257214418")]
    [DisplayName("Requested Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdXpryDt")]
    #endif
    [IsoXmlTag("ReqdXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedExpiryDate { get; init; } 
    #else
    public System.DateOnly? RequestedExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Document(s) presented for examination.
    /// </summary>
    [IsoId("_-BGHQXltEeG7BsjMvd1mEw_236846055")]
    [DisplayName("Demand Documentation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmndDcmnttn")]
    #endif
    [IsoXmlTag("DmndDcmnttn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DemandDocumentation1? DemandDocumentation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DemandDocumentation1? DemandDocumentation { get; init; } 
    #else
    public DemandDocumentation1? DemandDocumentation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the demand.
    /// </summary>
    [IsoId("_-BGHQ3ltEeG7BsjMvd1mEw_188236729")]
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
