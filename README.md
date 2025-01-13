# 📚 Multilingual Hanja Dictionary

Welcome to the **Multilingual Hanja Dictionary**! 🎉 This program is a command-line application that helps you explore and manage a dictionary of Korean words, their Hanja (Chinese characters), and their meanings. You can search for words, save new entries, change the interface language, and much more! 🌏✨

---

## 🌟 Features
- **Multilingual Support**: The program supports both English and French commands. Switch seamlessly between languages! 🇬🇧 🇫🇷
- **Search Functionality**: Find words by their Korean, Hanja, or definition.
- **Command History**: Save and load your command history for later use.
- **Customizable Dictionary**: Add new words to the dictionary as needed.
- **User-Friendly Commands**: Intuitive commands to interact with the dictionary.

---

## 📊 Data
The program uses a tab-separated values (TSV) file (`kengdic.tsv`) containing the following columns:
- `id`: Unique identifier for each dictionary entry.
- `surface`: Korean word.
- `hanja`: Corresponding Hanja (Chinese character).
- `gloss`: The English or French definition.

### Preprocessing
The data was preprocessed to ensure compatibility with UTF-8 encoding. This ensures support for non-Latin scripts such as Korean and Hanja.

---

## 🛠️ Commands
Here’s a list of commands you can use:

### 📖 General Commands
| Command              | Arguments                       | Description                                                   |
|----------------------|---------------------------------|---------------------------------------------------------------|
| **`help`**           | None                            | Displays a list of all available commands.                   |
| **`exit`**           | None                            | Exits the program.                                            |

### 🔍 Search Commands
| Command              | Arguments                       | Description                                                   |
|----------------------|---------------------------------|---------------------------------------------------------------|
| **`search [keyword]`** | `keyword` (required)           | Searches for a word in the dictionary by Korean, Hanja, or definition. |

### 💾 File Commands
| Command              | Arguments                       | Description                                                   |
|----------------------|---------------------------------|---------------------------------------------------------------|
| **`save [word]`**    | `word` (required)               | Saves a new word to the dictionary file.                     |
| **`load`**           | None                            | Loads the command history from a JSON file.                  |

### 🌍 Language Commands
| Command              | Arguments                       | Description                                                   |
|----------------------|---------------------------------|---------------------------------------------------------------|
| **`changeLang [ISO code]`** | `ISO code` (`en` or `fr`) | Changes the application language. Supported codes: `en`, `fr`. |

---

## 🚀 Example Usage
Here’s what a typical session might look like:

```plaintext
Welcome to the Multilingual Hanja Dictionary! Type 'help' for command options.

> help
Available Commands:
help - Lists all available commands.
search [keyword] - Searches for words in the dictionary.
save [word] - Adds a new word to the TSV file.
load - Loads the history of commands from a JSON file.
changeLang [ISO code] - Changes the application language (e.g., 'en', 'fr').
exit - Exits the application.

> search 乳房
乳房 (유방): Breast

> changeLang fr
Langue changée en français.

> aide
Commandes disponibles :
aide - Affiche toutes les commandes disponibles.
recherche [mot-clé] - Recherche des mots dans le dictionnaire.
sauvegarder [mot] - Ajoute un nouveau mot au fichier TSV.
charger - Charge l'historique des commandes depuis un fichier JSON.
changerLangue [ISO code] - Change la langue de l'application (ex. : 'en', 'fr').
sortie - Quitte l'application.

> sortie
Au revoir !