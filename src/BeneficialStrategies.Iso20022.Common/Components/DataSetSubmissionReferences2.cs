// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides references to the submitted data set both for the TSU and for the user.
/// </summary>
[IsoId("_UtVP09p-Ed-ak6NoX_4Aeg_-754867258")]
[DisplayName("Data Set Submission References")]
public partial record DataSetSubmissionReferences2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the TSU to the transaction.|This identification is to be used in any communication between the parties and with the TSU.
    /// </summary>
    [IsoId("_UtVP1Np-Ed-ak6NoX_4Aeg_-355906246")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Provides reference to the transaction for the financial institution that submits the data set.
    /// </summary>
    [IsoId("_UtVP1dp-Ed-ak6NoX_4Aeg_-355905659")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SubmitterTransactionReference { get; init; } 
    
    
    #nullable disable
    
}
