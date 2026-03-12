// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action instructed balance details at option level.
/// </summary>
[IsoId("_F90zIVB9Ee2KGNXAcFL5RA")]
[DisplayName("Corporate Action Instructed Balance Option Instruction SD")]
public partial record CorporateActionInstructedBalanceOptionInstructionSD5
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_GXc0EVB9Ee2KGNXAcFL5RA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_GXc0E1B9Ee2KGNXAcFL5RA")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    
    /// <summary>
    /// Instruction reference number assigned by DTC to the uncovered protect instruction.
    /// </summary>
    [IsoId("_GXc0G1B9Ee2KGNXAcFL5RA")]
    [DisplayName("Protect Identification")]
    [IsoXmlTag("PrtctId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public IsoMax15Text? ProtectIdentification { get; init; } 
    
    /// <summary>
    /// Contra CUSIP Identification of the option instruction.
    /// </summary>
    [IsoId("_GXc0HVB9Ee2KGNXAcFL5RA")]
    [DisplayName("Transaction Contra CUSIP")]
    [IsoXmlTag("TxContraCUSIP")]
    public OtherIdentification2? TransactionContraCUSIP { get; init; } 
    
    /// <summary>
    /// Quantity relating only to the oversubscription.
    /// </summary>
    [IsoId("_GXc0H1B9Ee2KGNXAcFL5RA")]
    [DisplayName("Transaction Identification Oversubscription Quantity")]
    [IsoXmlTag("TxIdOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_GXc0IVB9Ee2KGNXAcFL5RA")]
    [DisplayName("Transaction Identification Status")]
    [IsoXmlTag("TxIdSts")]
    public required DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    
    /// <summary>
    /// Tax category number assigned on the announcement to provide a breakdown at a category level on the inbound instruction to determine tax treatment as required by issuers, their agents, or tax authorities.
    /// </summary>
    [IsoId("_IaSOgVB9Ee2KGNXAcFL5RA")]
    [DisplayName("Tax Category")]
    [IsoXmlTag("TaxCtgy")]
    [MinLength(0)]
    [MaxLength(99)]
    public ValueList<TaxCategory2> TaxCategory { get; init; } = new ValueList<TaxCategory2>(){};
    
    
    #nullable disable
    
}
