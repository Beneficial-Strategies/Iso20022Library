// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the borrowing reason.
    /// </summary>
    [KnownType(typeof(BorrowingReason2Choice.Code))]
    [KnownType(typeof(BorrowingReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(BorrowingReason2Choice.Code),nameof(BorrowingReason2Choice.Code))]
    [JsonDerivedType(typeof(BorrowingReason2Choice.Proprietary),nameof(BorrowingReason2Choice.Proprietary))]
    [IsoId("_7OFNEZEjEeakHoV5BVecAQ")]
    [DisplayName("Borrowing Reason 2 Choice")]
    public abstract partial record BorrowingReason2Choice_
    {
    }
}
