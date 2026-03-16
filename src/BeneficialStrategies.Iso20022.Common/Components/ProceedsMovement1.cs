// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the proceeds movements.
/// </summary>
[IsoId("_Ri1Csdp-Ed-ak6NoX_4Aeg_1504216884")]
[DisplayName("Proceeds Movement")]
public record ProceedsMovement1
{
    /// <summary>
    /// Provides information about the movement of the cash proceeds.
    /// </summary>
    [IsoId("_Ri1Cstp-Ed-ak6NoX_4Aeg_-2002064127")]
    [DisplayName("Cash Proceeds Movement Details")]
    [IsoXmlTag("CshPrcdsMvmntDtls")]
    public CashProceeds1? CashProceedsMovementDetails { get; init; }

    /// <summary>
    /// Provides information about the movement of the securities proceeds.
    /// </summary>
    [IsoId("_Ri1Cs9p-Ed-ak6NoX_4Aeg_-2011300771")]
    [DisplayName("Securities Proceeds Movement Details")]
    [IsoXmlTag("SctiesPrcdsMvmntDtls")]
    public SecuritiesProceeds1? SecuritiesProceedsMovementDetails { get; init; }

    /// <summary>
    /// Provides information about the tax voucher.
    /// </summary>
    [IsoId("_Ri1CtNp-Ed-ak6NoX_4Aeg_-1986363312")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public TaxVoucher1? TaxDetails { get; init; }
}
