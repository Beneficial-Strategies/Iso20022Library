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
/// This record is an implementation of the supl.009.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DTCCCAPASD1 message extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Description(@"The DTCCCAPASD1 message extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.")]
[IsoId("_x6QSEQB6EeqouY-yI_q3qQ")]
[DisplayName("DTCCCAPASD 1 V")]
public partial record DTCCCAPASD1V08 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.009.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPASD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.009.001.08";
    
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
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_x6QSEwB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD43? CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_x6QSGwB6EeqouY-yI_q3qQ")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public FinancialInstrumentAttributesSD17? UnderlyingSecurity { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details.
    /// </summary>
    [IsoId("_x6QSHQB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Balance Details")]
    [IsoXmlTag("CorpActnBalDtls")]
    public CorporateActionBalanceSD4? CorporateActionBalanceDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_x6QSHwB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateActionSD18? CorporateActionDetails { get; init; } 
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement securities movement details.
    /// </summary>
    [IsoId("_x6QSIQB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Movement Securities Movement Details")]
    [IsoXmlTag("CorpActnMvmntSctiesMvmntDtls")]
    public CorporateActionMovementSecuritiesMovementDetailsSD5? CorporateActionMovementSecuritiesMovementDetails { get; init; } 
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement cash movement details.
    /// </summary>
    [IsoId("_x6QSKQB6EeqouY-yI_q3qQ")]
    [DisplayName("Corporate Action Movement Cash Movement Details")]
    [IsoXmlTag("CorpActnMvmntCshMvmntDtls")]
    public CorporateActionMovementCashMovementDetailsSD5? CorporateActionMovementCashMovementDetails { get; init; } 
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action option details.
    /// </summary>
    [IsoId("_x6QSMQB6EeqouY-yI_q3qQ")]
    [DisplayName("Option Transaction Details")]
    [IsoXmlTag("OptnTxDtls")]
    public OptionTransactionDetailsSD3? OptionTransactionDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since DTCCCAPASD1V08Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DTCCCAPASD1V08.

