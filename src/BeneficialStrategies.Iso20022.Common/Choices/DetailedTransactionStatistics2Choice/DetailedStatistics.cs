// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DetailedTransactionStatistics2Choice
{
    /// <summary>
    /// Information about number of transactions accepted and rejected and the reasons of the rejections.
    /// </summary>
    [IsoId("_hUsuw8K4EeuFNp8LZAnorg")]
    [DisplayName("Detailed Statistics")]
    public partial record DetailedStatistics : DetailedTransactionStatistics2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Total number of reports sent or received.
        /// </summary>
        [IsoId("_hV-hIcK4EeuFNp8LZAnorg")]
        [DisplayName("Total Number Of Transactions")]
        [IsoXmlTag("TtlNbOfTxs")]
        [IsoSimpleType(IsoSimpleType.Max15NumericText)]
        public required IsoMax15NumericText TotalNumberOfTransactions { get; init; } 
        
        /// <summary>
        /// Total number of transactions accepted.
        /// </summary>
        [IsoId("_hV-hI8K4EeuFNp8LZAnorg")]
        [DisplayName("Total Number Of Transactions Accepted")]
        [IsoXmlTag("TtlNbOfTxsAccptd")]
        [IsoSimpleType(IsoSimpleType.Max15NumericText)]
        public required IsoMax15NumericText TotalNumberOfTransactionsAccepted { get; init; } 
        
        /// <summary>
        /// Total number of transactions rejected.
        /// </summary>
        [IsoId("_hV-hJcK4EeuFNp8LZAnorg")]
        [DisplayName("Total Number Of Transactions Rejected")]
        [IsoXmlTag("TtlNbOfTxsRjctd")]
        [IsoSimpleType(IsoSimpleType.Max15NumericText)]
        public required IsoMax15NumericText TotalNumberOfTransactionsRejected { get; init; } 
        
        /// <summary>
        /// Details on transactions rejected per error code.
        /// </summary>
        [IsoId("_hV-hJ8K4EeuFNp8LZAnorg")]
        [DisplayName("Transactions Rejections Reason")]
        [IsoXmlTag("TxsRjctnsRsn")]
        public RejectionReason53? TransactionsRejectionsReason { get; init; } 
        
        
        #nullable disable
        
    }
}
