// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of document referred by the creditor.
    /// </summary>
    [KnownType(typeof(CreditorReferenceType1Choice.Code))]
    [KnownType(typeof(CreditorReferenceType1Choice.Proprietary))]
    [JsonDerivedType(typeof(CreditorReferenceType1Choice.Code),nameof(CreditorReferenceType1Choice.Code))]
    [JsonDerivedType(typeof(CreditorReferenceType1Choice.Proprietary),nameof(CreditorReferenceType1Choice.Proprietary))]
    [IsoId("_T3_jStp-Ed-ak6NoX_4Aeg_651436639")]
    [DisplayName("Creditor Reference Type 1 Choice")]
    public abstract partial record CreditorReferenceType1Choice_
    {
    }
}
