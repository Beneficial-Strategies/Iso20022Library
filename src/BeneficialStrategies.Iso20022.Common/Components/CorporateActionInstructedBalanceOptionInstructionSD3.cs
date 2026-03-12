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
[IsoId("_aq9fEegXEei5aPS232E3Mw")]
[DisplayName("Corporate Action Instructed Balance Option Instruction SD")]
public partial record CorporateActionInstructedBalanceOptionInstructionSD3
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_bOg4EegXEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_bOg4E-gXEei5aPS232E3Mw")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    
    /// <summary>
    /// Contra CUSIP Identification of the option instruction.
    /// </summary>
    [IsoId("_bOg4IegXEei5aPS232E3Mw")]
    [DisplayName("Transaction Contra CUSIP")]
    [IsoXmlTag("TxContraCUSIP")]
    public OtherIdentification2? TransactionContraCUSIP { get; init; } 
    
    /// <summary>
    /// Quantity relating only to the oversubscription.
    /// </summary>
    [IsoId("_bOg4JegXEei5aPS232E3Mw")]
    [DisplayName("Transaction Identification Oversubscription Quantity")]
    [IsoXmlTag("TxIdOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Status of the instruction.
    /// </summary>
    [IsoId("_bOg4J-gXEei5aPS232E3Mw")]
    [DisplayName("Transaction Identification Status")]
    [IsoXmlTag("TxIdSts")]
    public required DTCInstructionStatus2Code TransactionIdentificationStatus { get; init; } 
    
    
    #nullable disable
    
}
