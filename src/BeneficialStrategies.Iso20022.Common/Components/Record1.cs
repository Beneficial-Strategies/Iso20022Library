// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message in file message identified as a batch record.
/// </summary>
[IsoId("_k1mCsFBCEeedyPuM0kK2EQ")]
[DisplayName("Record")]
public partial record Record1
{
    #nullable enable
    
    /// <summary>
    /// Sequence counter of the record from 1 to n
    /// </summary>
    [IsoId("_6M0e8FBCEeedyPuM0kK2EQ")]
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber SequenceCounter { get; init; } 
    
    /// <summary>
    /// Value of the record to use for the computation of the checksum of the batch.
    /// </summary>
    [IsoId("_PDd9sFBDEeedyPuM0kK2EQ")]
    [DisplayName("Record Checksum Input Value")]
    [IsoXmlTag("RcrdChcksmInptVal")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? RecordChecksumInputValue { get; init; } 
    
    /// <summary>
    /// Information used with financial type of messages when third-party clearing is involved.
    /// </summary>
    [IsoId("_EKPGIFBKEeedyPuM0kK2EQ")]
    [DisplayName("Clearing Record Data")]
    [IsoXmlTag("ClrRcrdData")]
    public ClearingRecordData1? ClearingRecordData { get; init; } 
    
    /// <summary>
    /// Message to be sent in a batch transfer as a record.
    /// </summary>
    [IsoId("_Eu1NAFZVEeen1vB4iz5SyA")]
    [DisplayName("Record Message")]
    [IsoXmlTag("RcrdMsg")]
    public required RecordMessage1Choice_ RecordMessage { get; init; } 
    
    
    #nullable disable
    
}
