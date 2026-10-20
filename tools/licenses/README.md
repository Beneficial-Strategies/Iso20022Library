# License check

`check.sh` runs [nuget-license](https://github.com/garcipat/nuget-license) over the projects that are published to NuGet
(`published-projects.json`), including transitive packages, and fails when one has a license outside the allowed list
(`MIT`, `Apache-2.0`, `BSD-2-Clause`, `BSD-3-Clause`, `ISC`, `0BSD`) or none that it can determine. It runs in CI on every pull
request and in `publish.yml` before anything is packed.

* Adding a package with another license fails the check. Decide on purpose: extend the list in `check.sh` only for a license
  that fits MIT distribution, and say why in the pull request.
* A few Microsoft packages state their license only as a URL; `license-url-mappings.json` maps those URLs to the license
  (checked by hand). A new URL-only package fails with "Cannot determine License type" until it is mapped.
* The saga toolkit and the test projects are not published and are not scanned. The saga toolkit depends on MassTransit,
  whose license changed from version 9: check it before that package is ever published.
* This checks the licenses of the **packages we depend on**. It does not cover the ISO content in the definitions and
  documentation, which is ISO's (see the README).
* Scan results are only as good as what the packages declare; the check does not replace reading a license that matters.
