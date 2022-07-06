/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./**/*.{razor,cshtml}'],
  theme: {
    extend: {
      spacing: {
        'body': '48px'
      },
      colors:{
        'light-green': '#D8F3DC'
      }
    },
  },
  plugins: [],
}
