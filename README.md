# 🎯 Học C# với Exercism

![Exercism](https://img.shields.io/badge/Exercism-C%23-009CAB?logo=exercism&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-12-239120?logo=csharp&logoColor=white)
![Sync](https://img.shields.io/badge/GitHub%20Sync-auto-success)

Repo này lưu lại toàn bộ bài làm của mình trên [Exercism C# Track](https://exercism.org/tracks/csharp).
Mỗi khi mình **submit** hoặc **cập nhật** bài trên Exercism, bài làm sẽ được **tự động đồng bộ (auto sync)** về repo này qua tính năng *GitHub Syncing* của Exercism.

> ⚠️ Các file trong thư mục bài tập được Exercism tự động commit. Không nên chỉnh tay trừ khi cần sửa README hoặc ghi chú.

---

## 📚 Mục lục

- [Mục tiêu](#-mục-tiêu)
- [Cách auto sync hoạt động](#-cách-auto-sync-hoạt-động)
- [Thiết lập lần đầu](#-thiết-lập-lần-đầu)
- [Quy trình làm bài hằng ngày](#-quy-trình-làm-bài-hằng-ngày)
- [Cấu trúc thư mục](#-cấu-trúc-thư-mục)
- [Tiến độ](#-tiến-độ)
- [Nhật ký học tập](#-nhật-ký-học-tập)
- [Tài liệu tham khảo](#-tài-liệu-tham-khảo)

---

## 🎯 Mục tiêu

- [ ] Nắm vững cú pháp C# cơ bản (biến, kiểu dữ liệu, điều kiện, vòng lặp)
- [ ] Thành thạo `string`, `array`, `List<T>`, `Dictionary<K,V>`
- [ ] Hiểu OOP: class, interface, inheritance, polymorphism
- [ ] Dùng thành thạo LINQ
- [ ] Làm quen generics, delegates, events, `async/await`
- [ ] Viết code sạch, có unit test (xUnit)

---

## 🔄 Cách auto sync hoạt động

```
┌─────────────┐   submit    ┌───────────┐   auto sync   ┌──────────────┐
│ Máy local   │ ──────────► │ Exercism  │ ────────────► │ GitHub repo  │
│ (dotnet)    │             │ website   │               │ (repo này)   │
└─────────────┘             └───────────┘               └──────────────┘
```

1. Tải bài về bằng Exercism CLI và làm trên máy.
2. `exercism submit` để nộp bài lên Exercism.
3. Exercism tự động commit bài làm vào repo này (không cần `git push` thủ công).
4. Khi sửa lại và submit lần nữa, repo cũng được cập nhật theo.

---

## 🛠 Thiết lập lần đầu

### 1. Cài công cụ

| Công cụ | Link |
|---|---|
| .NET SDK | https://dotnet.microsoft.com/download |
| Exercism CLI | https://exercism.org/cli-walkthrough |
| Editor (VS Code / Rider / Visual Studio) | tuỳ chọn |

Kiểm tra:

```bash
dotnet --version
exercism version
```

### 2. Cấu hình Exercism CLI

Lấy token tại <https://exercism.org/settings/api_cli>:

```bash
exercism configure --token=YOUR_API_TOKEN
exercism configure --workspace=~/exercism
```

### 3. Bật GitHub Syncing

1. Vào <https://exercism.org/settings/integrations>.
2. Mục **GitHub Syncing** → **Connect to GitHub** → cài **Exercism GitHub App** và chọn repo này.
3. Chọn **Sync all solutions** hoặc chỉ các bài đã hoàn thành (tuỳ nhu cầu).
4. Bật tuỳ chọn **Sync automatically** để mỗi lần submit sẽ tự đồng bộ.
5. (Tuỳ chọn) Bấm **Sync everything now** để đẩy toàn bộ bài cũ lên repo.

> 💡 Có thể cấu hình thêm thư mục lưu bài và có/không đồng bộ file đi kèm (README, ghi chú…) ngay trong trang Settings.

---

## 🔁 Quy trình làm bài hằng ngày

```bash
# 1. Tải bài tập
exercism download --exercise=hello-world --track=csharp

# 2. Vào thư mục bài tập
cd ~/exercism/csharp/hello-world

# 3. Đọc đề (README.md / .docs) và code trong file .cs

# 4. Chạy test
dotnet test

# 5. Nộp bài (Exercism sẽ tự sync về GitHub)
exercism submit HelloWorld.cs
```

### ✅ Checklist mỗi bài

- [ ] Đọc kỹ `.docs/instructions.md`
- [ ] Test pass 100% (`dotnet test`)
- [ ] Refactor cho gọn, đặt tên rõ ràng
- [ ] Submit và xem lại phần *Community solutions*
- [ ] Ghi chú điều học được vào [Nhật ký học tập](#-nhật-ký-học-tập)

---

## 📁 Cấu trúc thư mục

Ví dụ (thực tế phụ thuộc cấu hình sync của bạn):

```
.
├── README.md
├── csharp/
│   ├── hello-world/
│   │   ├── HelloWorld.cs
│   │   ├── HelloWorld.csproj
│   │   ├── HelloWorldTests.cs
│   │   └── .exercism/
│   ├── lucians-luscious-lasagna/
│   └── ...
└── notes/            # ghi chú cá nhân (tuỳ chọn)
```

---

## 📈 Tiến độ

| Chủ đề | Bài tập | Trạng thái |
|---|---|---|
| Basics | `hello-world`, `lucians-luscious-lasagna` | ⬜ |
| Numbers | `gigasecond`, `leap` | ⬜ |
| Strings | `reverse-string`, `pangram`, `isogram` | ⬜ |
| Conditionals | `leap`, `raindrops` | ⬜ |
| Arrays / Lists | `high-scores`, `hamming` | ⬜ |
| Dictionaries | `word-count`, `etl` | ⬜ |
| Classes & OOP | `bank-account`, `robot-simulator` | ⬜ |
| LINQ | `isogram`, `anagram` | ⬜ |
| Generics & Async | `custom-set`, `parallel-letter-frequency` | ⬜ |

> Ký hiệu: ⬜ Chưa làm · 🟨 Đang làm · ✅ Hoàn thành

**Thống kê chung:** `0 / ?` bài hoàn thành

---

## 📝 Nhật ký học tập

### Ngày 1 — dd/mm/yyyy
- **Bài:** `hello-world`
- **Học được:** cấu trúc một file C# cơ bản, cách chạy test bằng `dotnet test`.
- **Khó khăn:** …
- **Cách cải thiện:** …

<!-- Sao chép mẫu trên cho mỗi buổi học -->

---

## 🔗 Tài liệu tham khảo

- [Exercism C# Track](https://exercism.org/tracks/csharp)
- [Exercism – GitHub Syncing](https://exercism.org/docs/using/solving-exercises/github-syncing)
- [Microsoft Learn – C# docs](https://learn.microsoft.com/dotnet/csharp/)
- [C# Language Reference](https://learn.microsoft.com/dotnet/csharp/language-reference/)
- [xUnit.net](https://xunit.net/)

---

## 📄 Giấy phép

Bài tập thuộc bản quyền Exercism và cộng đồng đóng góp. Code lời giải do mình tự viết phục vụ mục đích học tập.
