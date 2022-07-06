/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./**/*.{razor,cshtml}'],
  theme: {
    extend: {
      spacing: {
        'body': '48px'
      },
      colors:{
        'main-green': '#005C22'
      }
    },
  },
  plugins: [],
}
