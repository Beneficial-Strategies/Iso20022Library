// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the borrowing reason.
    /// </summary>
    [KnownType(typeof(BorrowingReason1Choice.Code))]
    [KnownType(typeof(BorrowingReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(BorrowingReason1Choice.Code),nameof(BorrowingReason1Choice.Code))]
    [JsonDerivedType(typeof(BorrowingReason1Choice.Proprietary),nameof(BorrowingReason1Choice.Proprietary))]
    [IsoId("_AYq0IdokEeC60axPepSq7g_1157886245")]
    [DisplayName("Borrowing Reason 1 Choice")]
    public abstract partial record BorrowingReason1Choice_
    {
    }
}
