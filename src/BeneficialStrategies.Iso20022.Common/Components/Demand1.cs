// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the demand.
/// </summary>
[IsoId("_-AylQnltEeG7BsjMvd1mEw_1908468693")]
[DisplayName("Demand")]
public partial record Demand1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the presenting party to the demand.
    /// </summary>
    [IsoId("_-AylQ3ltEeG7BsjMvd1mEw_-2057301709")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Type of demand.
    /// </summary>
    [IsoId("_-AylRHltEeG7BsjMvd1mEw_-1446215965")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DemandType1Code Type { get; init; } 
    
    /// <summary>
    /// Details related to the undertaking.
    /// </summary>
    [IsoId("_-AylRXltEeG7BsjMvd1mEw_-1068410070")]
    [DisplayName("Undertaking Identification")]
    [IsoXmlTag("UdrtkgId")]
    public required Undertaking6 UndertakingIdentification { get; init; } 
    
    /// <summary>
    /// Details related to the demand amount.
    /// </summary>
    [IsoId("_-AylRnltEeG7BsjMvd1mEw_-2023766673")]
    [DisplayName("Demand Amount")]
    [IsoXmlTag("DmndAmt")]
    public required UndertakingAmount3 DemandAmount { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the advising party to the undertaking.
    /// </summary>
    [IsoId("_-A8WQHltEeG7BsjMvd1mEw_1331805812")]
    [DisplayName("Advising Party Reference Number")]
    [IsoXmlTag("AdvsgPtyRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdvisingPartyReferenceNumber { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the second advising party to the undertaking.
    /// </summary>
    [IsoId("_8977YBVQEeKVqNjC36CBuQ")]
    [DisplayName("Second Advising Party Reference Number")]
    [IsoXmlTag("ScndAdvsgPtyRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecondAdvisingPartyReferenceNumber { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the confirmer to the undertaking.
    /// </summary>
    [IsoId("_-A8WQXltEeG7BsjMvd1mEw_-346168184")]
    [DisplayName("Confirmer Reference Number")]
    [IsoXmlTag("CnfrmrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ConfirmerReferenceNumber { get; init; } 
    
    /// <summary>
    /// Details related to the settlement account.
    /// </summary>
    [IsoId("_-A8WQ3ltEeG7BsjMvd1mEw_-1782957178")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount27? SettlementAccount { get; init; } 
    
    /// <summary>
    /// Details of the beneficiary&apos;s presentation of documents.
    /// </summary>
    [IsoId("_-A8WRHltEeG7BsjMvd1mEw_-275427375")]
    [DisplayName("Presentation Details")]
    [IsoXmlTag("PresntnDtls")]
    public Presentation2? PresentationDetails { get; init; } 
    
    /// <summary>
    /// Requested new expiry date as an alternative to payment of the demand.
    /// </summary>
    [IsoId("_-BGHQHltEeG7BsjMvd1mEw_257214418")]
    [DisplayName("Requested Expiry Date")]
    [IsoXmlTag("ReqdXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExpiryDate { get; init; } 
    
    /// <summary>
    /// Document(s) presented for examination.
    /// </summary>
    [IsoId("_-BGHQXltEeG7BsjMvd1mEw_236846055")]
    [DisplayName("Demand Documentation")]
    [IsoXmlTag("DmndDcmnttn")]
    public DemandDocumentation1? DemandDocumentation { get; init; } 
    
    /// <summary>
    /// Additional information related to the demand.
    /// </summary>
    [IsoId("_-BGHQ3ltEeG7BsjMvd1mEw_188236729")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
