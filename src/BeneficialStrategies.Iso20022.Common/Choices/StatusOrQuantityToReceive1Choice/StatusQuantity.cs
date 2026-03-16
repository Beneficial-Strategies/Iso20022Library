// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrQuantityToReceive1Choice
{
    /// <summary>
    /// Quantity of securities that has been assigned the status indicated.
    /// </summary>
    [IsoId("_UGvw8Np-Ed-ak6NoX_4Aeg_1067930264")]
    [DisplayName("Status Quantity")]
    public record StatusQuantity : StatusOrQuantityToReceive1Choice_ { }
}
