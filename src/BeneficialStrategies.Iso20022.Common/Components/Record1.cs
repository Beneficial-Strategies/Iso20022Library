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
/// Message in file message identified as a batch record.
/// </summary>
[IsoId("_k1mCsFBCEeedyPuM0kK2EQ")]
[DisplayName("Record")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Record1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Record1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Record1( System.UInt64 reqSequenceCounter,RecordMessage1Choice_ reqRecordMessage )
    {
        SequenceCounter = reqSequenceCounter;
        RecordMessage = reqRecordMessage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequence counter of the record from 1 to n
    /// </summary>
    [IsoId("_6M0e8FBCEeedyPuM0kK2EQ")]
    [DisplayName("Sequence Counter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqCntr")]
    #endif
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber SequenceCounter { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 SequenceCounter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 SequenceCounter { get; init; } 
    #else
    public System.UInt64 SequenceCounter { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the record to use for the computation of the checksum of the batch.
    /// </summary>
    [IsoId("_PDd9sFBDEeedyPuM0kK2EQ")]
    [DisplayName("Record Checksum Input Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdChcksmInptVal")]
    #endif
    [IsoXmlTag("RcrdChcksmInptVal")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? RecordChecksumInputValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? RecordChecksumInputValue { get; init; } 
    #else
    public System.Byte[]? RecordChecksumInputValue { get; set; } 
    #endif
    
    /// <summary>
    /// Information used with financial type of messages when third-party clearing is involved.
    /// </summary>
    [IsoId("_EKPGIFBKEeedyPuM0kK2EQ")]
    [DisplayName("Clearing Record Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrRcrdData")]
    #endif
    [IsoXmlTag("ClrRcrdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingRecordData1? ClearingRecordData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingRecordData1? ClearingRecordData { get; init; } 
    #else
    public ClearingRecordData1? ClearingRecordData { get; set; } 
    #endif
    
    /// <summary>
    /// Message to be sent in a batch transfer as a record.
    /// </summary>
    [IsoId("_Eu1NAFZVEeen1vB4iz5SyA")]
    [DisplayName("Record Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdMsg")]
    #endif
    [IsoXmlTag("RcrdMsg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RecordMessage1Choice_ RecordMessage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RecordMessage1Choice_ RecordMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RecordMessage1Choice_ RecordMessage { get; init; } 
    #else
    public RecordMessage1Choice_ RecordMessage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
