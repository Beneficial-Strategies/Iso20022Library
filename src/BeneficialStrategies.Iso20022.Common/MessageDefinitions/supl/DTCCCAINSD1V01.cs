// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.008.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_1Mz5EDL3EeKU9IrkkToqcw_1438480682")]
[DisplayName("DTCCCAINSD 1 V")]
public partial record DTCCCAINSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.008.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAINSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.008.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) Optional Dividend service election.
    /// </summary>
    [IsoId("_1Mz5ETL3EeKU9IrkkToqcw_-868730910")]
    [DisplayName("Optional Dividend")]
    [IsoXmlTag("OptnlDvdd")]
    public OptionalDividendAccountQuantitySD1? OptionalDividend { get; init; } 
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) Tax Exempt service election.
    /// </summary>
    [IsoId("_1Mz5EjL3EeKU9IrkkToqcw_1039926111")]
    [DisplayName("Tax Exempt")]
    [IsoXmlTag("TaxXmpt")]
    public TaxExemptQuantitySD1? TaxExempt { get; init; } 
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) Foreign Currency Payment service wire payment instruction.
    /// </summary>
    [IsoId("_1Mz5EzL3EeKU9IrkkToqcw_-2087888194")]
    [DisplayName("Wire Instruction")]
    [IsoXmlTag("WireInstr")]
    public WireInstructionSD1? WireInstruction { get; init; } 
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) Tax Relief service election.
    /// </summary>
    [IsoId("_1Mz5FDL3EeKU9IrkkToqcw_-1885590787")]
    [DisplayName("DTC Tax Relief")]
    [IsoXmlTag("DTCTaxRlf")]
    public DTCTaxReliefSD2? DTCTaxRelief { get; init; } 
    
    /// <summary>
    /// U.S. Tax Withholding elections.
    /// </summary>
    [IsoId("_1Mz5FTL3EeKU9IrkkToqcw_-63987189")]
    [DisplayName("US Tax Withholding")]
    [IsoXmlTag("USTaxWhldg")]
    public USTaxWithholdingSD1? USTaxWithholding { get; init; } 
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) Cash In Lieu service election.
    /// </summary>
    [IsoId("_1Mz5FjL3EeKU9IrkkToqcw_1321235420")]
    [DisplayName("Cash In Lieu")]
    [IsoXmlTag("CshInLieu")]
    public CashInLieuSD1? CashInLieu { get; init; } 
    
    
    #nullable disable
    
}


// Since DTCCCAINSD1V01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCAINSD1V01.

