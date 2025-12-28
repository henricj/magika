// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Magika;

/// <summary>
///     Content types for files that can be identified by Magika.
/// </summary>
public enum ContentType
{
    /// <summary>3GPP multimedia file</summary>
    _3gp,

    /// <summary>ACE archive</summary>
    Ace,

    /// <summary>Adobe Illustrator Artwork</summary>
    Ai,

    /// <summary>Android Interface Definition Language</summary>
    Aidl,

    /// <summary>Android package</summary>
    Apk,

    /// <summary>Apple binary property list</summary>
    Applebplist,

    /// <summary>Apple property list</summary>
    Appleplist,

    /// <summary>Assembly</summary>
    Asm,

    /// <summary>ASP source</summary>
    Asp,

    /// <summary>AutoHotKey script</summary>
    Autohotkey,

    /// <summary>AutoIt script</summary>
    Autoit,

    /// <summary>Awk</summary>
    Awk,

    /// <summary>DOS batch file</summary>
    Batch,

    /// <summary>Bazel build file</summary>
    Bazel,

    /// <summary>BibTeX</summary>
    Bib,

    /// <summary>BMP image data</summary>
    Bmp,

    /// <summary>bzip2 compressed data</summary>
    Bzip,

    /// <summary>C source</summary>
    C,

    /// <summary>Microsoft Cabinet archive data</summary>
    Cab,

    /// <summary>Windows Catalog file</summary>
    Cat,

    /// <summary>MS Windows HtmlHelp Data</summary>
    Chm,

    /// <summary>Clojure</summary>
    Clojure,

    /// <summary>CMake build file</summary>
    Cmake,

    /// <summary>Cobol</summary>
    Cobol,

    /// <summary>Intel 80386 COFF</summary>
    Coff,

    /// <summary>CoffeeScript</summary>
    Coffeescript,

    /// <summary>C++ source</summary>
    Cpp,

    /// <summary>Certificates (binary format)</summary>
    Crt,

    /// <summary>Google Chrome extension</summary>
    Crx,

    /// <summary>C# source</summary>
    Cs,

    /// <summary>.NET project config</summary>
    Csproj,

    /// <summary>CSS source</summary>
    Css,

    /// <summary>CSV document</summary>
    Csv,

    /// <summary>Dart source</summary>
    Dart,

    /// <summary>Debian binary package</summary>
    Deb,

    /// <summary>Dalvik dex file</summary>
    Dex,

    /// <summary>DICOM</summary>
    Dicom,

    /// <summary>Diff file</summary>
    Diff,

    /// <summary>Dream Maker</summary>
    Dm,

    /// <summary>Apple disk image</summary>
    Dmg,

    /// <summary>Microsoft Word CDF document</summary>
    Doc,

    /// <summary>Dockerfile</summary>
    Dockerfile,

    /// <summary>Microsoft Word 2007+ document</summary>
    Docx,

    /// <summary>Application Desktop Services Store</summary>
    Dsstore,

    /// <summary>Autocad Drawing</summary>
    Dwg,

    /// <summary>Audocad Drawing Exchange Format</summary>
    Dxf,

    /// <summary>ELF executable</summary>
    Elf,

    /// <summary>Elixir script</summary>
    Elixir,

    /// <summary>Windows Enhanced Metafile image data</summary>
    Emf,

    /// <summary>RFC 822 mail</summary>
    Eml,

    /// <summary>Empty file</summary>
    Empty,

    /// <summary>EPUB document</summary>
    Epub,

    /// <summary>Embedded Ruby source</summary>
    Erb,

    /// <summary>Erlang source</summary>
    Erlang,

    /// <summary>FLAC audio bitstream data</summary>
    Flac,

    /// <summary>Flash Video</summary>
    Flv,

    /// <summary>Fortran</summary>
    Fortran,

    /// <summary>Gemfile file</summary>
    Gemfile,

    /// <summary>Gemspec file</summary>
    Gemspec,

    /// <summary>GIF image data</summary>
    Gif,

    /// <summary>Gitattributes file</summary>
    Gitattributes,

    /// <summary>Gitmodules file</summary>
    Gitmodules,

    /// <summary>Golang source</summary>
    Go,

    /// <summary>Gradle source</summary>
    Gradle,

    /// <summary>Groovy source</summary>
    Groovy,

    /// <summary>gzip compressed data</summary>
    Gzip,

    /// <summary>Hierarchical Data Format v5</summary>
    H5,

    /// <summary>Handlebars source</summary>
    Handlebars,

    /// <summary>Haskell source</summary>
    Haskell,

    /// <summary>HashiCorp configuration language</summary>
    Hcl,

    /// <summary>MS Windows help</summary>
    Hlp,

    /// <summary>Apache access configuration</summary>
    Htaccess,

    /// <summary>HTML document</summary>
    Html,

    /// <summary>Mac OS X icon</summary>
    Icns,

    /// <summary>MS Windows icon resource</summary>
    Ico,

    /// <summary>Internet Calendaring and Scheduling</summary>
    Ics,

    /// <summary>Ignorefile</summary>
    Ignorefile,

    /// <summary>INI configuration file</summary>
    Ini,

    /// <summary>MS Windows Internet shortcut</summary>
    Internetshortcut,

    /// <summary>Jupyter notebook</summary>
    Ipynb,

    /// <summary>ISO 9660 CD-ROM filesystem data</summary>
    Iso,

    /// <summary>Java archive data (JAR)</summary>
    Jar,

    /// <summary>Java source</summary>
    Java,

    /// <summary>Java compiled bytecode</summary>
    Javabytecode,

    /// <summary>JavaScript source</summary>
    Javascript,

    /// <summary>Jinja template</summary>
    Jinja,

    /// <summary>jpeg2000</summary>
    Jp2,

    /// <summary>JPEG image data</summary>
    Jpeg,

    /// <summary>JSON document</summary>
    Json,

    /// <summary>JSONL document</summary>
    Jsonl,

    /// <summary>Julia source</summary>
    Julia,

    /// <summary>Kotlin source</summary>
    Kotlin,

    /// <summary>LaTeX document</summary>
    Latex,

    /// <summary>LHarc archive</summary>
    Lha,

    /// <summary>Lisp source</summary>
    Lisp,

    /// <summary>MS Windows shortcut</summary>
    Lnk,

    /// <summary>Lua</summary>
    Lua,

    /// <summary>M3U playlist</summary>
    M3u,

    /// <summary>GNU Macro</summary>
    M4,

    /// <summary>Mach-O executable</summary>
    Macho,

    /// <summary>Makefile source</summary>
    Makefile,

    /// <summary>Markdown document</summary>
    Markdown,

    /// <summary>Matlab Source</summary>
    Matlab,

    /// <summary>MHTML document</summary>
    Mht,

    /// <summary>Midi</summary>
    Midi,

    /// <summary>Matroska</summary>
    Mkv,

    /// <summary>MP3 media file</summary>
    Mp3,

    /// <summary>MP4 media file</summary>
    Mp4,

    /// <summary>MS Compress archive data</summary>
    Mscompress,

    /// <summary>Microsoft Installer file</summary>
    Msi,

    /// <summary>Windows Update Package file</summary>
    Mum,

    /// <summary>Numpy Array</summary>
    Npy,

    /// <summary>Numpy Arrays Archive</summary>
    Npz,

    /// <summary>NuGet Package</summary>
    Nupkg,

    /// <summary>ObjectiveC source</summary>
    Objectivec,

    /// <summary>OCaml</summary>
    Ocaml,

    /// <summary>OpenDocument Presentation</summary>
    Odp,

    /// <summary>OpenDocument Spreadsheet</summary>
    Ods,

    /// <summary>OpenDocument Text</summary>
    Odt,

    /// <summary>Ogg data</summary>
    Ogg,

    /// <summary>One Note</summary>
    One,

    /// <summary>Open Neural Network Exchange</summary>
    Onnx,

    /// <summary>OpenType font</summary>
    Otf,

    /// <summary>MS Outlook Message</summary>
    Outlook,

    /// <summary>Apache Parquet</summary>
    Parquet,

    /// <summary>Pascal source</summary>
    Pascal,

    /// <summary>pcap capture file</summary>
    Pcap,

    /// <summary>Windows Program Database</summary>
    Pdb,

    /// <summary>PDF document</summary>
    Pdf,

    /// <summary>PE Windows executable</summary>
    Pebin,

    /// <summary>PEM certificate</summary>
    Pem,

    /// <summary>Perl source</summary>
    Perl,

    /// <summary>PHP source</summary>
    Php,

    /// <summary>Python pickle</summary>
    Pickle,

    /// <summary>PNG image</summary>
    Png,

    /// <summary>Portable Object (PO) for i18n</summary>
    Po,

    /// <summary>PostScript document</summary>
    Postscript,

    /// <summary>Powershell source</summary>
    Powershell,

    /// <summary>Microsoft PowerPoint CDF document</summary>
    Ppt,

    /// <summary>Microsoft PowerPoint 2007+ document</summary>
    Pptx,

    /// <summary>Prolog source</summary>
    Prolog,

    /// <summary>Protein DB</summary>
    Proteindb,

    /// <summary>Protocol buffer definition</summary>
    Proto,

    /// <summary>Adobe Photoshop</summary>
    Psd,

    /// <summary>Python source</summary>
    Python,

    /// <summary>Python compiled bytecode</summary>
    Pythonbytecode,

    /// <summary>Pytorch storage file</summary>
    Pytorch,

    /// <summary>QuickTime</summary>
    Qt,

    /// <summary>R (language)</summary>
    R,

    /// <summary>Random bytes</summary>
    Randombytes,

    /// <summary>Random text</summary>
    Randomtxt,

    /// <summary>RAR archive data</summary>
    Rar,

    /// <summary>Resource Description Framework document (RDF)</summary>
    Rdf,

    /// <summary>RedHat Package Manager archive (RPM)</summary>
    Rpm,

    /// <summary>ReStructuredText document</summary>
    Rst,

    /// <summary>Rich Text Format document</summary>
    Rtf,

    /// <summary>Ruby source</summary>
    Ruby,

    /// <summary>Rust source</summary>
    Rust,

    /// <summary>Scala source</summary>
    Scala,

    /// <summary>SCSS source</summary>
    Scss,

    /// <summary>7-zip archive data</summary>
    Sevenzip,

    /// <summary>sgml</summary>
    Sgml,

    /// <summary>Shell script</summary>
    Shell,

    /// <summary>Smali source</summary>
    Smali,

    /// <summary>Snap archive</summary>
    Snap,

    /// <summary>Solidity source</summary>
    Solidity,

    /// <summary>SQL source</summary>
    Sql,

    /// <summary>SQLITE database</summary>
    Sqlite,

    /// <summary>Squash filesystem</summary>
    Squashfs,

    /// <summary>SubRip Text Format</summary>
    Srt,

    /// <summary>Stereolithography CAD (binary)</summary>
    Stlbinary,

    /// <summary>Stereolithography CAD (text)</summary>
    Stltext,

    /// <summary>Checksum file</summary>
    Sum,

    /// <summary>SVG Scalable Vector Graphics image data</summary>
    Svg,

    /// <summary>Small Web File</summary>
    Swf,

    /// <summary>Swift</summary>
    Swift,

    /// <summary>POSIX tar archive</summary>
    Tar,

    /// <summary>Tickle</summary>
    Tcl,

    /// <summary>Text protocol buffer</summary>
    Textproto,

    /// <summary>Targa image data</summary>
    Tga,

    /// <summary>Windows thumbnail cache</summary>
    Thumbsdb,

    /// <summary>TIFF image data</summary>
    Tiff,

    /// <summary>Tom's obvious, minimal language</summary>
    Toml,

    /// <summary>BitTorrent file</summary>
    Torrent,

    /// <summary>TSV document</summary>
    Tsv,

    /// <summary>TrueType Font data</summary>
    Ttf,

    /// <summary>Twig template</summary>
    Twig,

    /// <summary>Generic text document</summary>
    Txt,

    /// <summary>TypeScript source</summary>
    Typescript,

    /// <summary>Undefined</summary>
    Undefined,

    /// <summary>Unknown binary data</summary>
    Unknown,

    /// <summary>MS Visual Basic source (VBA)</summary>
    Vba,

    /// <summary>Visual Studio MSBuild project</summary>
    Vcxproj,

    /// <summary>Verilog source</summary>
    Verilog,

    /// <summary>VHDL source</summary>
    Vhdl,

    /// <summary>Web Video Text Tracks</summary>
    Vtt,

    /// <summary>Vue source</summary>
    Vue,

    /// <summary>Web Assembly</summary>
    Wasm,

    /// <summary>Waveform Audio file (WAV)</summary>
    Wav,

    /// <summary>WebM media file</summary>
    Webm,

    /// <summary>WebP media file</summary>
    Webp,

    /// <summary>Windows Registry text</summary>
    Winregistry,

    /// <summary>Windows metafile</summary>
    Wmf,

    /// <summary>Web Open Font Format</summary>
    Woff,

    /// <summary>Web Open Font Format v2</summary>
    Woff2,

    /// <summary>XAR archive compressed data</summary>
    Xar,

    /// <summary>Microsoft Excel CDF document</summary>
    Xls,

    /// <summary>Microsoft Excel 2007+ document (binary format)</summary>
    Xlsb,

    /// <summary>Microsoft Excel 2007+ document</summary>
    Xlsx,

    /// <summary>XML document</summary>
    Xml,

    /// <summary>Compressed installation archive (XPI)</summary>
    Xpi,

    /// <summary>XZ compressed data</summary>
    Xz,

    /// <summary>YAML source</summary>
    Yaml,

    /// <summary>YARA rule</summary>
    Yara,

    /// <summary>Zig source</summary>
    Zig,

    /// <summary>Zip archive data</summary>
    Zip,

    /// <summary>zlib compressed data</summary>
    Zlibstream,

    // Special types (not from model output)
    /// <summary>A directory</summary>
    Directory,

    /// <summary>Symbolic link</summary>
    Symlink
}