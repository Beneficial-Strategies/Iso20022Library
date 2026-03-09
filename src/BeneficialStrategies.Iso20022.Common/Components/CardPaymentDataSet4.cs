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
/// Set of transactions to capture, sharing common characteristics.
/// </summary>
[IsoId("_05Z9QQvZEeKzJ69IWwzB9Q")]
[DisplayName("Card Payment Data Set")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentDataSet4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentDataSet4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentDataSet4( DataSetIdentification1 reqDataSetIdentification )
    {
        DataSetIdentification = reqDataSetIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the data set.
    /// </summary>
    [IsoId("_1Et1YQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetIdentification1 DataSetIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataSetIdentification1 DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetIdentification1 DataSetIdentification { get; init; } 
    #else
    public DataSetIdentification1 DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of partners involved in the data set building.
    /// </summary>
    [IsoId("_1Et1ZQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Traceability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tracblt")]
    #endif
    [IsoXmlTag("Tracblt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Traceability1? Traceability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Traceability1? Traceability { get; init; } 
    #else
    public Traceability1? Traceability { get; set; } 
    #endif
    
    /// <summary>
    /// Initiator of the data set.
    /// </summary>
    [IsoId("_1Et1aQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Data Set Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetInitr")]
    #endif
    [IsoXmlTag("DataSetInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification32? DataSetInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32? DataSetInitiator { get; init; } 
    #else
    public GenericIdentification32? DataSetInitiator { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction totals of the data set.
    /// </summary>
    [IsoId("_1Et1bQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Transaction Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTtls")]
    #endif
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals2> TransactionTotals { get; init; } = new ValueList<TransactionTotals2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _1Et1bQvZEeKzJ69IWwzB9Q
    
    /// <summary>
    /// Data common to all transactions of the data set.
    /// </summary>
    [IsoId("_1Et1cQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Common Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonData")]
    #endif
    [IsoXmlTag("CmonData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommonData2? CommonData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommonData2? CommonData { get; init; } 
    #else
    public CommonData2? CommonData { get; set; } 
    #endif
    
    /// <summary>
    /// Set of transaction to Process.
    /// </summary>
    [IsoId("_lpQ7sC8SEeKW5usMQLtzqw")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    public ValueList<CardPaymentDataSetTransaction1Choice_> Transaction { get; init; } = new ValueList<CardPaymentDataSetTransaction1Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _lpQ7sC8SEeKW5usMQLtzqw
    
    
    #nullable disable
    
}
