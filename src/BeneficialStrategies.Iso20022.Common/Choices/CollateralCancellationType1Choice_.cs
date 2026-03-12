// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a proprietary code for the reason the collateral message has been cancelled.
    /// </summary>
    [KnownType(typeof(CollateralCancellationType1Choice.Code))]
    [KnownType(typeof(CollateralCancellationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(CollateralCancellationType1Choice.Code),nameof(CollateralCancellationType1Choice.Code))]
    [JsonDerivedType(typeof(CollateralCancellationType1Choice.Proprietary),nameof(CollateralCancellationType1Choice.Proprietary))]
    [IsoId("_QmogONp-Ed-ak6NoX_4Aeg_-847110751")]
    [DisplayName("Collateral Cancellation Type 1 Choice")]
    public abstract partial record CollateralCancellationType1Choice_
    {
    }
}
