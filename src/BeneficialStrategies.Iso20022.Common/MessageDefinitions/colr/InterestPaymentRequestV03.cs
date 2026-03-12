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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.013.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This InterestPaymentRequest message is sent by either;
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager, or
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager
/// It is used to request payment or advise the amount due for interest calculated for a specified period. The interest is based on the amount of collateral that has been held during the calculation period. It is possible to send these messages on a bi-lateral basis for matching.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// The InterestPaymentRequest message is used to advise the interest amount calculated for a specific period or request payment for an interest amount for a specific period.
/// </summary>
[Description(@"Scope|This InterestPaymentRequest message is sent by either;|- the collateral taker or its collateral manager to the collateral giver or its collateral manager, or|- the collateral giver or its collateral manager to the collateral taker or its collateral manager|It is used to request payment or advise the amount due for interest calculated for a specified period. The interest is based on the amount of collateral that has been held during the calculation period. It is possible to send these messages on a bi-lateral basis for matching.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The InterestPaymentRequest message is used to advise the interest amount calculated for a specific period or request payment for an interest amount for a specific period.")]
[IsoId("_2wqKwWNnEeSIWbZ6by9dnA")]
[DisplayName("Interest Payment Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestPaymentRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.013.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntrstPmtReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.013.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InterestPaymentRequestV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InterestPaymentRequestV03( System.String reqTransactionIdentification,Obligation3 reqObligation,Agreement2 reqAgreement )
    {
        TransactionIdentification = reqTransactionIdentification;
        Obligation = reqObligation;
        Agreement = reqAgreement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_2wqKw2NnEeSIWbZ6by9dnA")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_SDIoAGNpEeSIWbZ6by9dnA")]
    [DisplayName("Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oblgtn")]
    #endif
    [IsoXmlTag("Oblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Obligation3 Obligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Obligation3 Obligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Obligation3 Obligation { get; init; } 
    #else
    public Obligation3 Obligation { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_2wqKzWNnEeSIWbZ6by9dnA")]
    [DisplayName("Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agrmt")]
    #endif
    [IsoXmlTag("Agrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Agreement2 Agreement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Agreement2 Agreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Agreement2 Agreement { get; init; } 
    #else
    public Agreement2 Agreement { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the interest amount due to party A.
    /// </summary>
    [IsoId("_2wqKz2NnEeSIWbZ6by9dnA")]
    [DisplayName("Interest Due To A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstDueToA")]
    #endif
    [IsoXmlTag("IntrstDueToA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestAmount1? InterestDueToA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestAmount1? InterestDueToA { get; init; } 
    #else
    public InterestAmount1? InterestDueToA { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the interest amount due to party B.
    /// </summary>
    [IsoId("_2wqK0WNnEeSIWbZ6by9dnA")]
    [DisplayName("Interest Due To B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstDueToB")]
    #endif
    [IsoXmlTag("IntrstDueToB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestAmount1? InterestDueToB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestAmount1? InterestDueToB { get; init; } 
    #else
    public InterestAmount1? InterestDueToB { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the net interest amount due to A or due to B in case of collateral held and posted during a period.
    /// </summary>
    [IsoId("_2wqK02NnEeSIWbZ6by9dnA")]
    [DisplayName("Net Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmtDtls")]
    #endif
    [IsoXmlTag("NetAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestResult1? NetAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestResult1? NetAmountDetails { get; init; } 
    #else
    public InterestResult1? NetAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2wqK1WNnEeSIWbZ6by9dnA")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since InterestPaymentRequestV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InterestPaymentRequestV03.

