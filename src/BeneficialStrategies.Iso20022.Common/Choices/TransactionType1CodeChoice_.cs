// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the transaction type.
    /// </summary>
    [KnownType(typeof(TransactionType1CodeChoice.Structured))]
    [KnownType(typeof(TransactionType1CodeChoice.Unstructured))]
    [JsonDerivedType(typeof(TransactionType1CodeChoice.Structured),nameof(TransactionType1CodeChoice.Structured))]
    [JsonDerivedType(typeof(TransactionType1CodeChoice.Unstructured),nameof(TransactionType1CodeChoice.Unstructured))]
    [IsoId("_U0V2wdp-Ed-ak6NoX_4Aeg_1816953757")]
    [DisplayName("Transaction Type 1 Code Choice")]
    public abstract partial record TransactionType1CodeChoice_
    {
    }
}
